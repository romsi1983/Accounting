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
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrgGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrgGridView
            // 
            this.OrgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrgGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.City,
            this.Address,
            this.Phone,
            this.Active,
            this.Comment});
            this.OrgGridView.Location = new System.Drawing.Point(1, 31);
            this.OrgGridView.Name = "OrgGridView";
            this.OrgGridView.Size = new System.Drawing.Size(755, 418);
            this.OrgGridView.TabIndex = 0;
            this.OrgGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrgGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Наименование";
            this.Name.Name = "Name";
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
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            // 
            // Active
            // 
            this.Active.HeaderText = "Активный";
            this.Active.Name = "Active";
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Коментарий";
            this.Comment.Name = "Comment";
            // 
            // OrgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 598);
            this.Controls.Add(this.OrgGridView);
            //this.Name = "OrgForm";
            this.Text = "OrgForm";
            this.Load += new System.EventHandler(this.OrgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrgGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrgGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}