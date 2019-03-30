namespace Accounting.Forms
{
    partial class ContractsAll
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newContract = new System.Windows.Forms.Button();
            this.companyContracts = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessedVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.newContract, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.companyContracts, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.60284F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.39716F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 252);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // newContract
            // 
            this.newContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newContract.Location = new System.Drawing.Point(2, 2);
            this.newContract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newContract.Name = "newContract";
            this.newContract.Size = new System.Drawing.Size(501, 35);
            this.newContract.TabIndex = 0;
            this.newContract.Text = "Новый договор";
            this.newContract.UseVisualStyleBackColor = true;
            this.newContract.Click += new System.EventHandler(this.newContract_Click);
            // 
            // companyContracts
            // 
            this.companyContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.companyContracts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.companyContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ContractNumber,
            this.FromData,
            this.ToDate,
            this.TargetVolume,
            this.ProcessedVolume});
            this.companyContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyContracts.Location = new System.Drawing.Point(2, 41);
            this.companyContracts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.companyContracts.Name = "companyContracts";
            this.companyContracts.ReadOnly = true;
            this.companyContracts.RowTemplate.Height = 24;
            this.companyContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companyContracts.Size = new System.Drawing.Size(501, 209);
            this.companyContracts.TabIndex = 1;
            this.companyContracts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.companyContracts_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ContractNumber
            // 
            this.ContractNumber.HeaderText = "Номер договора";
            this.ContractNumber.Name = "ContractNumber";
            this.ContractNumber.ReadOnly = true;
            // 
            // FromData
            // 
            this.FromData.HeaderText = "Действует С";
            this.FromData.Name = "FromData";
            this.FromData.ReadOnly = true;
            // 
            // ToDate
            // 
            this.ToDate.HeaderText = "Дейсвует По";
            this.ToDate.Name = "ToDate";
            this.ToDate.ReadOnly = true;
            // 
            // TargetVolume
            // 
            this.TargetVolume.HeaderText = "Объем";
            this.TargetVolume.Name = "TargetVolume";
            this.TargetVolume.ReadOnly = true;
            // 
            // ProcessedVolume
            // 
            this.ProcessedVolume.HeaderText = "Вывезенный объем";
            this.ProcessedVolume.Name = "ProcessedVolume";
            this.ProcessedVolume.ReadOnly = true;
            // 
            // ContractsAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 252);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContractsAll";
            this.Text = "Договора";
            this.Load += new System.EventHandler(this.ContractsAll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button newContract;
        private System.Windows.Forms.DataGridView companyContracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessedVolume;
    }
}