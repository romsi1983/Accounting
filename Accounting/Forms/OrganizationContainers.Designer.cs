namespace Accounting.Forms
{
    partial class OrganizationContainers
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
            this.addContainer = new System.Windows.Forms.Button();
            this.deleteContainer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orgContData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptaformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgContData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 467F));
            this.tableLayoutPanel1.Controls.Add(this.addContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteContainer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addContainer
            // 
            this.addContainer.Location = new System.Drawing.Point(2, 2);
            this.addContainer.Margin = new System.Windows.Forms.Padding(2);
            this.addContainer.Name = "addContainer";
            this.addContainer.Size = new System.Drawing.Size(126, 41);
            this.addContainer.TabIndex = 0;
            this.addContainer.Text = "Добавить контейнер";
            this.addContainer.UseVisualStyleBackColor = true;
            this.addContainer.Click += new System.EventHandler(this.addContainer_Click);
            // 
            // deleteContainer
            // 
            this.deleteContainer.Location = new System.Drawing.Point(136, 3);
            this.deleteContainer.Name = "deleteContainer";
            this.deleteContainer.Size = new System.Drawing.Size(135, 40);
            this.deleteContainer.TabIndex = 1;
            this.deleteContainer.Text = "Удалить контейнер";
            this.deleteContainer.UseVisualStyleBackColor = true;
            this.deleteContainer.Click += new System.EventHandler(this.deleteContainer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.orgContData, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(600, 120);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // orgContData
            // 
            this.orgContData.AllowUserToAddRows = false;
            this.orgContData.AllowUserToDeleteRows = false;
            this.orgContData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orgContData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orgContData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.containerColumn,
            this.ptaformColumn,
            this.scheduleColumn});
            this.orgContData.Dock = System.Windows.Forms.DockStyle.Top;
            this.orgContData.Location = new System.Drawing.Point(2, 2);
            this.orgContData.Margin = new System.Windows.Forms.Padding(2);
            this.orgContData.Name = "orgContData";
            this.orgContData.ReadOnly = true;
            this.orgContData.RowTemplate.Height = 24;
            this.orgContData.Size = new System.Drawing.Size(596, 116);
            this.orgContData.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // containerColumn
            // 
            this.containerColumn.HeaderText = "Тип контейнера";
            this.containerColumn.Name = "containerColumn";
            this.containerColumn.ReadOnly = true;
            // 
            // ptaformColumn
            // 
            this.ptaformColumn.HeaderText = "Адрес площадки";
            this.ptaformColumn.Name = "ptaformColumn";
            this.ptaformColumn.ReadOnly = true;
            // 
            // scheduleColumn
            // 
            this.scheduleColumn.HeaderText = "Расписание";
            this.scheduleColumn.Name = "scheduleColumn";
            this.scheduleColumn.ReadOnly = true;
            // 
            // OrganizationContainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 163);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrganizationContainers";
            this.Text = "Контейнеры организации";
            this.Load += new System.EventHandler(this.OrganizationContainers_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orgContData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView orgContData;
        private System.Windows.Forms.Button addContainer;
        private System.Windows.Forms.Button deleteContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptaformColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleColumn;
    }
}