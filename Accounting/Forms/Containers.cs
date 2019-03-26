using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting.Forms
{
    public partial class Containers : Form
    {
        public Containers()
        {
            InitializeComponent();
        }

        private void dataContainers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Containers_Load(object sender, EventArgs e)
        {
            dataContainers.Rows.Clear();
            var sql = new SqLiteHelper();
            List<ContainerType> dbContainers = sql.FindinTable<ContainerType>();

            foreach (var value in dbContainers)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataContainers);
                row.Cells[0].Value = value.Id;
                row.Cells[1].Value = value.Name;
                dataContainers.Rows.Add(row);
            }
        }

        private void dataContainers_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var row = dataContainers.CurrentRow;
            if (row != null) row.Cells[0].Value = row.Index + 1;
        }

        private void Containers_FormClosing(object sender, FormClosingEventArgs e)
        {   
            var sql = new SqLiteHelper();
            for (var i = 0; i < dataContainers.RowCount; i++)
            {
                var row = dataContainers.Rows[i];
                

                var conName = (string)row.Cells[1].Value;
                var conId = row.Cells[0].Value;

                if (String.IsNullOrEmpty(conName)) continue;
                var cont = new ContainerType
                {

                    Id = Convert.ToInt32(conId),
                    Name = conName
                };

                sql.UpdateDb(cont);
            }


        }
    }
}
