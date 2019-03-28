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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.orgContData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.containerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptaformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addContainer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgContData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 389F));
            this.tableLayoutPanel1.Controls.Add(this.addContainer, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.orgContData, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 381);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // orgContData
            // 
            this.orgContData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orgContData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orgContData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.containerColumn,
            this.ptaformColumn,
            this.scheduleColumn});
            this.orgContData.Dock = System.Windows.Forms.DockStyle.Top;
            this.orgContData.Location = new System.Drawing.Point(3, 3);
            this.orgContData.Name = "orgContData";
            this.orgContData.RowTemplate.Height = 24;
            this.orgContData.Size = new System.Drawing.Size(794, 150);
            this.orgContData.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // containerColumn
            // 
            this.containerColumn.HeaderText = "Тип контейнера";
            this.containerColumn.Name = "containerColumn";
            // 
            // ptaformColumn
            // 
            this.ptaformColumn.HeaderText = "Адрес площадки";
            this.ptaformColumn.Name = "ptaformColumn";
            // 
            // scheduleColumn
            // 
            this.scheduleColumn.HeaderText = "Расписание";
            this.scheduleColumn.Name = "scheduleColumn";
            // 
            // addContainer
            // 
            this.addContainer.Location = new System.Drawing.Point(3, 3);
            this.addContainer.Name = "addContainer";
            this.addContainer.Size = new System.Drawing.Size(168, 51);
            this.addContainer.TabIndex = 0;
            this.addContainer.Text = "Добавить контейнер";
            this.addContainer.UseVisualStyleBackColor = true;
            this.addContainer.Click += new System.EventHandler(this.addContainer_Click);
            // 
            // OrganizationContainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn containerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptaformColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleColumn;
        private System.Windows.Forms.Button addContainer;
    }
}