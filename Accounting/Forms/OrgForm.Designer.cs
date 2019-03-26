namespace Accounting
{
    partial class OrgForm
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

        private void OrgForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Accounting form = new Accounting();
            //form.ShowDialog();
            //this.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrgGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewCompany = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrgGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrgGridView
            // 
            this.OrgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrgGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OrgName,
            this.City,
            this.Address,
            this.Phone});
            this.OrgGridView.Location = new System.Drawing.Point(12, 95);
            this.OrgGridView.Name = "OrgGridView";
            this.OrgGridView.Size = new System.Drawing.Size(793, 353);
            this.OrgGridView.TabIndex = 0;
            this.OrgGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrgGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // OrgName
            // 
            this.OrgName.HeaderText = "Наименование";
            this.OrgName.Name = "OrgName";
            this.OrgName.Width = 200;
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.Width = 120;
            // 
            // NewCompany
            // 
            this.NewCompany.Location = new System.Drawing.Point(12, 12);
            this.NewCompany.Name = "NewCompany";
            this.NewCompany.Size = new System.Drawing.Size(151, 68);
            this.NewCompany.TabIndex = 1;
            this.NewCompany.Text = "Новая организация";
            this.NewCompany.UseVisualStyleBackColor = true;
            this.NewCompany.Click += new System.EventHandler(this.NewCompany_Click);
            // 
            // OrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 457);
            this.Controls.Add(this.NewCompany);
            this.Controls.Add(this.OrgGridView);
            this.Name = "OrgForm";
            this.Text = "OrgForm";
            this.Load += new System.EventHandler(this.OrgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrgGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrgGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button NewCompany;
    }
}