namespace Accounting.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pathLabel = new System.Windows.Forms.Label();
            this.dbPath = new System.Windows.Forms.TextBox();
            this.changeDbPath = new System.Windows.Forms.Button();
            this.findDB = new System.Windows.Forms.OpenFileDialog();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(13, 13);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(107, 13);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Путь к базе данных";
            // 
            // dbPath
            // 
            this.dbPath.Location = new System.Drawing.Point(12, 40);
            this.dbPath.Name = "dbPath";
            this.dbPath.ReadOnly = true;
            this.dbPath.Size = new System.Drawing.Size(264, 20);
            this.dbPath.TabIndex = 1;
            // 
            // changeDbPath
            // 
            this.changeDbPath.Location = new System.Drawing.Point(126, 8);
            this.changeDbPath.Name = "changeDbPath";
            this.changeDbPath.Size = new System.Drawing.Size(150, 23);
            this.changeDbPath.TabIndex = 2;
            this.changeDbPath.Text = "изменить";
            this.changeDbPath.UseVisualStyleBackColor = true;
            this.changeDbPath.Click += new System.EventHandler(this.changeDbPath_Click);
            // 
            // findDB
            // 
            this.findDB.FileName = "main.db";
            this.findDB.Title = "Укажите путь к базе данных";
            this.findDB.FileOk += new System.ComponentModel.CancelEventHandler(this.findDB_FileOk);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(126, 66);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(150, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Сохранить настройки";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 99);
            this.Controls.Add(this.save);
            this.Controls.Add(this.changeDbPath);
            this.Controls.Add(this.dbPath);
            this.Controls.Add(this.pathLabel);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox dbPath;
        private System.Windows.Forms.Button changeDbPath;
        private System.Windows.Forms.OpenFileDialog findDB;
        private System.Windows.Forms.Button save;
    }
}