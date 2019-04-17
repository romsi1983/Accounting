using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;

namespace Accounting.SQLite
{
    class PrepareAccounting : SqLiteHelper
    {
        public void PrepareDb(bool onStart)
        {
            var dbPath = GetDbPath();
            if (onStart)
            {
                CreateDb(dbPath);
                UpdateDb();
            }
            else InitSqlLite(dbPath);
            
            SetRelevace();
            if (!Processed())
            {
                PutFlagActive();
                FillInTodaysContainers();
            }
        }

        private void InitSqlLite(string dbPath)
        {
            if (SqlLite == null)
            {
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
            }
        }

        private bool Processed()
        {
            var processed = ExecuteTextCommand("SELECT Processed FROM Relevance").FirstOrDefault();
            if (processed != null && (long)processed != 0) return true;
            return false;
        }

        private void FillInTodaysContainers()
        {
            //Check if Data was already processed
            var processed = ExecuteTextCommand("SELECT Processed FROM Relevance").FirstOrDefault();
            if (processed != null && (long)processed != 0) return;
            //Delete all processed
            ExecuteWriteCommand(@"DELETE FROM ContainersQueue WHERE Processed = '1'");
            //Increment all unprocessed
            ExecuteWriteCommand(@"UPDATE ContainersQueue SET Dayspast = Dayspast + 1");
            //Insert New
            var dayOfTheWeek = string.Empty;
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayOfTheWeek = "7";
                    break;
                case DayOfWeek.Monday:
                    dayOfTheWeek = "1";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfTheWeek = "2";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfTheWeek = "3";
                    break;
                case DayOfWeek.Thursday:
                    dayOfTheWeek = "4";
                    break;
                case DayOfWeek.Friday:
                    dayOfTheWeek = "5";
                    break;
                case DayOfWeek.Saturday:
                    dayOfTheWeek = "6";
                    break;
            }
            //var dayOfTheWeek = DateTime.Today.DayOfWeek.GetHashCode();
            var sqlCommand = $"SELECT OrganizationContainers.Id " +
                             $"FROM OrganizationContainers " +
                             $"INNER JOIN Organizations " +
                             $"ON Organizations.Id = OrganizationContainers.Organization " +
                             $"WHERE Organizations.Active = 1 " +
                             $"AND OrganizationContainers.Schedule LIKE '%{dayOfTheWeek}%'";

            var todaysContainers = ExecuteTextCommand(sqlCommand);
            foreach (var value in todaysContainers)
            {
                ExecuteWriteCommand(@"INSERT INTO ContainersQueue (Container,Dayspast,Processed) " +
                                    $"VALUES ('{value}','0','0')");
            }
            //Set that Data was processed
            ExecuteWriteCommand(@"UPDATE Relevance SET Processed = '1' WHERE Id = '1'");
        }

        private void PutFlagActive()
        {
            var today = DateTime.Today;
            var todayString = today.ToString("yyyy-MM-dd");
            var sqlCommand = @"SELECT Organization FROM Contracts " +
                             $"WHERE '{todayString}' >= FromDate " +
                             $"AND '{todayString}' <= ToDate " +
                             @"AND ProcessedVolume < TargetVolume";

            var activeCompanies = ExecuteTextCommand(sqlCommand).ToList();
            sqlCommand = @"SELECT Organizations.Id, Organizations.Active From Organizations";
            var allOrgs = ExecuteTextCommand(sqlCommand);
            foreach (object[] org in allOrgs)
            {
                var orgId = (long) org[0];
                var orgActive = (long)org[1];
                var change = string.Empty;
                if (activeCompanies.Contains(orgId) && orgActive == 0)
                {
                    change = $"UPDATE Organizations SET Active = '1' WHERE Id = '{orgId}'";
                }
                else if (!activeCompanies.Contains(orgId) && orgActive == 1)
                {
                    change = $"UPDATE Organizations SET Active = '0' WHERE Id = '{orgId}'";
                }
                if (!String.IsNullOrEmpty(change))
                {
                    ExecuteWriteCommand(change);
                }
            }
        }
        private void UpdateDb()
        {
            var currentVersion = (long)ExecuteTextCommand("PRAGMA user_version")[0];

            if (currentVersion < 1)
            {
                ExecuteWriteCommand(@"ALTER TABLE Containers ADD Volume FLOAT");
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS OrganizationsNew
                    (Id INTEGER PRIMARY KEY,
                     Name VARCHAR(255) NOT NULL,
                     City VARCHAR(255) NOT NULL,
                     Address VARCHAR(255),
                     Phone VARCHAR(255),
                     Active TINYINTEGER NOT NULL DEFAULT 1,
                     Comment VARCHAR(255))");
                ExecuteWriteCommand(@"INSERT INTO OrganizationsNew (Id,Name,City,Address,Phone,Active)
                    SELECT Id,Name,City,Address,Phone,Active FROM Organizations");
                ExecuteWriteCommand(@"DROP TABLE Organizations");
                ExecuteWriteCommand(@"ALTER TABLE OrganizationsNew RENAME TO Organizations");

                ExecuteWriteCommand("PRAGMA user_version=1");
                currentVersion++;
            }

            if (currentVersion < 2)
            {
                ExecuteWriteCommand(@"DROP TABLE IF EXISTS Сontract");
                ExecuteWriteCommand("PRAGMA user_version=2");
                currentVersion++;
            }

            if (currentVersion < 3)
            {
                ExecuteWriteCommand(@"ALTER TABLE Containers ADD Multiple TINYINTEGER NOT NULL DEFAULT 1");
                ExecuteWriteCommand("PRAGMA user_version=3");
                currentVersion++;
            }

            if (currentVersion < 4)
            {
                //Organizations
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS OrganizationsNew
                    (Id INTEGER PRIMARY KEY,
                     Name VARCHAR(255) NOT NULL UNIQUE,
                     City VARCHAR(255) NOT NULL,
                     Address VARCHAR(255),
                     Phone VARCHAR(255),
                     Active TINYINTEGER NOT NULL DEFAULT 1,
                     Comment VARCHAR(255))");
                ExecuteWriteCommand(@"INSERT INTO OrganizationsNew (Id,Name,City,Address,Phone,Active)
                    SELECT DISTINCT Id,Name,City,Address,Phone,Active FROM Organizations");
                ExecuteWriteCommand(@"DROP TABLE Organizations");
                ExecuteWriteCommand(@"ALTER TABLE OrganizationsNew RENAME TO Organizations");
                //Containers
                ExecuteWriteCommand(
                    @"CREATE TABLE IF NOT EXISTS ContainersNew(Id INTEGER NOT NULL PRIMARY KEY, Name VARCHAR(255) NOT NULL UNIQUE,
                    Volume FLOAT NOT NULL,Multiple TINYINTEGER NOT NULL DEFAULT 1)");
                ExecuteWriteCommand(@"INSERT INTO ContainersNew (Id,Name,Volume,Multiple)
                    SELECT Id,Name,Volume,Multiple FROM Containers");
                ExecuteWriteCommand(@"DROP TABLE Containers");
                ExecuteWriteCommand(@"ALTER TABLE ContainersNew RENAME TO Containers");
                //Platforms
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS PlatformsNew (Id INTEGER NOT NULL PRIMARY KEY,Address VARCHAR(255) NOT NULL UNIQUE)");
                ExecuteWriteCommand(@"INSERT INTO PlatformsNew (Id,Address) SELECT Id,Address FROM Platforms");
                ExecuteWriteCommand(@"DROP TABLE Platforms");
                ExecuteWriteCommand(@"ALTER TABLE PlatformsNew RENAME TO Platforms");
                //Drivers
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS DriversNew (Id INTEGER NOT NULL PRIMARY KEY, Name VARCHAR(255) NOT NULL UNIQUE)");
                ExecuteWriteCommand(@"INSERT INTO DriversNew (Id,Name) SELECT Id, Name FROM Drivers");
                ExecuteWriteCommand(@"DROP TABLE Drivers");
                ExecuteWriteCommand(@"ALTER TABLE DriversNew RENAME TO Drivers");
                //Cars
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS CarsNew (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL,
                    Number VARCHAR(255) NOT NULL UNIQUE)");
                ExecuteWriteCommand(@"INSERT INTO CarsNew (Id,Name,Number) SELECT Id, Name, Number FROM Cars");
                ExecuteWriteCommand(@"DROP TABLE Cars");
                ExecuteWriteCommand(@"ALTER TABLE CarsNew RENAME TO Cars");
                //Contracts
                ExecuteWriteCommand(@"DROP TABLE IF EXISTS Contracts");
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS Contracts(Id INTEGER NOT NULL PRIMARY KEY, 
                    ContractNumber VARCHAR(255) NOT NULL UNIQUE, 
                    Organization INTEGER NOT NULL,
                    FromDate DATETIME NOT NULL, 
                    ToDate DATETIME NOT NULL, 
                    TargetVolume FLOAT NOT NULL, 
                    ProcessedVolume FLOAT)");
                ExecuteWriteCommand("PRAGMA user_version=4");
            }

            if (currentVersion < 5)
            {
                ExecuteWriteCommand(@"DROP TABLE IF EXISTS Registry");
                ExecuteWriteCommand(@"CREATE TABLE IF NOT EXISTS Registry
                    (Id INTEGER PRIMARY KEY,
                     Organization INTEGER NOT NULL,
                     Contract INTEGER NOT NULL,
                     Container INTEGER NOT NULL,
                     Platform INTEGER NOT NULL,
                     Driver INTEGER NOT NULL,
                     Car INTEGER NOT NULL,
                     Volume FLOAT NOT NULL,
                     Entered DATETIME NOT NULL)");
                ExecuteWriteCommand("PRAGMA user_version=5");
            }
        }
        private void SetRelevace()
        {
            var today = DateTime.Today;
            var todayString = today.ToString("yyyy-MM-dd");
            var releveance = ExecuteTextCommand("SELECT Today FROM Relevance").FirstOrDefault();
            if (releveance == null)
            {
                ExecuteWriteCommand(@"INSERT INTO Relevance (Today,Processed) " +
                                    $"VALUES ('{todayString}','0')");
            }
            else
            {
                if ((DateTime)releveance < today)
                    ExecuteWriteCommand(@"UPDATE Relevance " +
                                        $"SET Today = '{todayString}',Processed='0' " +
                                        @"WHERE Id = '1'");
            }
        }
        private void CreateDb(string dbPath)
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
                ExecuteWriteCommand("PRAGMA user_version=4");
                SqlLite.Close();
                SqlLite = null;
            }

            if (SqlLite == null)
            {
                SqlLite = new SQLiteConnection($"Data Source={dbPath}");
                SqlLite.Open();
            }

            SqlLite = new SQLiteConnection($"Data Source={dbPath}");
            SqlLite.Open();

            List<string> sqlCommands = new List<string>
            {
                @"CREATE TABLE IF NOT EXISTS Organizations
                    (Id INTEGER PRIMARY KEY,
                    Name VARCHAR(255) NOT NULL UNIQUE,
                    City VARCHAR(255) NOT NULL,
                    Address VARCHAR(255),
                    Phone VARCHAR(255),
                    Active TINYINTEGER NOT NULL DEFAULT 1,
                    Comment VARCHAR(255))",
                @"CREATE TABLE IF NOT EXISTS Containers (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL UNIQUE,
                    Volume FLOAT NOT NULL, Multiple TINYINTEGER NOT NULL DEFAULT 1)",
                @"CREATE TABLE IF NOT EXISTS Platforms (Id INTEGER NOT NULL PRIMARY KEY,Address VARCHAR(255) NOT NULL UNIQUE)",
                @"CREATE TABLE IF NOT EXISTS OrganizationContainers (Id INTEGER NOT NULL PRIMARY KEY, 
                    Organization INTEGER NOT NULL, Container INTEGER NOT NULL, Platform INTEGER NOT NULL, 
                    Schedule VARCHAR(255))",
                @"CREATE TABLE IF NOT EXISTS Drivers (Id INTEGER NOT NULL PRIMARY KEY, Name VARCHAR(255) NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Cars (Id INTEGER NOT NULL PRIMARY KEY,Name VARCHAR(255) NOT NULL,
                    Number VARCHAR(255) NOT NULL UNIQUE)",
                @"CREATE TABLE IF NOT EXISTS Registry
                    (Id INTEGER NOT NULL PRIMARY KEY,
                    Organization INTEGER NOT NULL,
                    Contract INTEGER NOT NULL,
                    Container INTEGER NOT NULL,
                    Platform INTEGER NOT NULL,
                    Driver INTEGER NOT NULL,
                    Car INTEGER NOT NULL,
                    Volume FLOAT NOT NULL,
                    Entered DATETIME NOT NULL)",
                @"CREATE TABLE IF NOT EXISTS Contracts(Id INTEGER NOT NULL PRIMARY KEY, 
                    ContractNumber VARCHAR(255) NOT NULL UNIQUE, 
                    Organization INTEGER NOT NULL,
                    FromDate DATETIME NOT NULL, 
                    ToDate DATETIME NOT NULL, 
                    TargetVolume FLOAT NOT NULL, 
                    ProcessedVolume FLOAT DEFAULT 0)",
                @"CREATE TABLE IF NOT EXISTS Relevance(Id INTEGER NOT NULL PRIMARY KEY,
                    Today DATETIME NOT NULL,
                    Processed TINYINTEGER NOT NULL DEFAULT 0)",
                @"CREATE TABLE IF NOT EXISTS ContainersQueue(Id INTEGER NOT NULL PRIMARY KEY, 
                    Container INTEGER NOT NULL, Dayspast INTEGER, Processed TINYINTEGER NOT NULL DEFAULT 0)"
            };

            foreach (var sqlCommand in sqlCommands)
            {
                ExecuteWriteCommand(sqlCommand);
            }
        }
    }
}
