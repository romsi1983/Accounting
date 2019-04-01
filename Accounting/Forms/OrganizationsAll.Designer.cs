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
            this.OrgGridView.Location = new System.Drawing.Point(4, 4);
            this.OrgGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrgGridView.MultiSelect = false;
            this.OrgGridView.Name = "OrgGridView";
            this.OrgGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrgGridView.Size = new System.Drawing.Size(1161, 479);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1169, 487);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // orgContainers
            // 
            this.orgContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgContainers.Location = new System.Drawing.Point(974, 4);
            this.orgContainers.Margin = new System.Windows.Forms.Padding(4);
            this.orgContainers.Name = "orgContainers";
            this.orgContainers.Size = new System.Drawing.Size(191, 45);
            this.orgContainers.TabIndex = 3;
            this.orgContainers.Text = "Контейнера";
            this.orgContainers.UseVisualStyleBackColor = true;
            this.orgContainers.Click += new System.EventHandler(this.orgContainers_Click);
            // 
            // OrgConracts
            // 
            this.OrgConracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrgConracts.Location = new System.Drawing.Point(780, 4);
            this.OrgConracts.Margin = new System.Windows.Forms.Padding(4);
            this.OrgConracts.Name = "OrgConracts";
            this.OrgConracts.Size = new System.Drawing.Size(186, 45);
            this.OrgConracts.TabIndex = 2;
            this.OrgConracts.Text = "Договора";
            this.OrgConracts.UseVisualStyleBackColor = true;
            this.OrgConracts.Click += new System.EventHandler(this.OrgConracts_Click);
            // 
            // NewCompany
            // 
            this.NewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewCompany.Location = new System.Drawing.Point(586, 4);
            this.NewCompany.Margin = new System.Windows.Forms.Padding(4);
            this.NewCompany.Name = "NewCompany";
            this.NewCompany.Size = new System.Drawing.Size(186, 45);
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
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1169, 81);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // orgFilterLabel
            // 
            this.orgFilterLabel.AutoSize = true;
            this.orgFilterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orgFilterLabel.Location = new System.Drawing.Point(3, 36);
            this.orgFilterLabel.Name = "orgFilterLabel";
            this.orgFilterLabel.Size = new System.Drawing.Size(188, 17);
            this.orgFilterLabel.TabIndex = 4;
            this.orgFilterLabel.Text = "Фильтр по наименованию:";
            // 
            // orgFilter
            // 
            this.orgFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgFilter.Location = new System.Drawing.Point(3, 56);
            this.orgFilter.Name = "orgFilter";
            this.orgFilter.Size = new System.Drawing.Size(188, 22);
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.84849F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 578);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // OrganizationsAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}