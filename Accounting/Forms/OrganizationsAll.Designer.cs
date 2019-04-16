namespace Accounting.Forms
{
    partial class OrganizationsAll
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orgContainers = new System.Windows.Forms.Button();
            this.OrgConracts = new System.Windows.Forms.Button();
            this.NewCompany = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.orgFilterLabel = new System.Windows.Forms.Label();
            this.orgFilter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addressFilterLabel = new System.Windows.Forms.Label();
            this.addressFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrgGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrgGridView
            // 
            this.OrgGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrgGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrgGridView.Location = new System.Drawing.Point(3, 3);
            this.OrgGridView.MultiSelect = false;
            this.OrgGridView.Name = "OrgGridView";
            this.OrgGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrgGridView.Size = new System.Drawing.Size(871, 389);
            this.OrgGridView.TabIndex = 0;
            this.OrgGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrgGridView_CellContentClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.OrgGridView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 73);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(877, 395);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // orgContainers
            // 
            this.orgContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgContainers.Location = new System.Drawing.Point(733, 3);
            this.orgContainers.Name = "orgContainers";
            this.orgContainers.Size = new System.Drawing.Size(141, 37);
            this.orgContainers.TabIndex = 3;
            this.orgContainers.Text = "Контейнера";
            this.orgContainers.UseVisualStyleBackColor = true;
            this.orgContainers.Click += new System.EventHandler(this.orgContainers_Click);
            // 
            // OrgConracts
            // 
            this.OrgConracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrgConracts.Location = new System.Drawing.Point(587, 3);
            this.OrgConracts.Name = "OrgConracts";
            this.OrgConracts.Size = new System.Drawing.Size(140, 37);
            this.OrgConracts.TabIndex = 2;
            this.OrgConracts.Text = "Договора";
            this.OrgConracts.UseVisualStyleBackColor = true;
            this.OrgConracts.Click += new System.EventHandler(this.OrgConracts_Click);
            // 
            // NewCompany
            // 
            this.NewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewCompany.Location = new System.Drawing.Point(441, 3);
            this.NewCompany.Name = "NewCompany";
            this.NewCompany.Size = new System.Drawing.Size(140, 37);
            this.NewCompany.TabIndex = 1;
            this.NewCompany.Text = "Новая организация";
            this.NewCompany.UseVisualStyleBackColor = true;
            this.NewCompany.Click += new System.EventHandler(this.NewCompany_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.NewCompany, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.OrgConracts, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.orgContainers, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.orgFilterLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.orgFilter, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.addressFilterLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.addressFilter, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(877, 67);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // orgFilterLabel
            // 
            this.orgFilterLabel.AutoSize = true;
            this.orgFilterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orgFilterLabel.Location = new System.Drawing.Point(2, 17);
            this.orgFilterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orgFilterLabel.Name = "orgFilterLabel";
            this.orgFilterLabel.Size = new System.Drawing.Size(142, 26);
            this.orgFilterLabel.TabIndex = 4;
            this.orgFilterLabel.Text = "Фильтр по наименованию:";
            // 
            // orgFilter
            // 
            this.orgFilter.Location = new System.Drawing.Point(2, 45);
            this.orgFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orgFilter.Name = "orgFilter";
            this.orgFilter.Size = new System.Drawing.Size(142, 20);
            this.orgFilter.TabIndex = 5;
            this.orgFilter.TextChanged += new System.EventHandler(this.orgFilter_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.84849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 470);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // addressFilterLabel
            // 
            this.addressFilterLabel.AutoSize = true;
            this.addressFilterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addressFilterLabel.Location = new System.Drawing.Point(149, 30);
            this.addressFilterLabel.Name = "addressFilterLabel";
            this.addressFilterLabel.Size = new System.Drawing.Size(140, 13);
            this.addressFilterLabel.TabIndex = 6;
            this.addressFilterLabel.Text = "Фильтр по адресу:";
            // 
            // addressFilter
            // 
            this.addressFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressFilter.Location = new System.Drawing.Point(149, 46);
            this.addressFilter.Name = "addressFilter";
            this.addressFilter.Size = new System.Drawing.Size(140, 20);
            this.addressFilter.TabIndex = 7;
            this.addressFilter.TextChanged += new System.EventHandler(this.addressFilter_TextChanged);
            // 
            // OrganizationsAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OrganizationsAll";
            this.Text = "Организации";
            this.Load += new System.EventHandler(this.OrgForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrgGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrgGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button orgContainers;
        private System.Windows.Forms.Button OrgConracts;
        private System.Windows.Forms.Button NewCompany;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label orgFilterLabel;
        private System.Windows.Forms.TextBox orgFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label addressFilterLabel;
        private System.Windows.Forms.TextBox addressFilter;
    }
}