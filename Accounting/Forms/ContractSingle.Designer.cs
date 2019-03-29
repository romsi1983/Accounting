namespace Accounting.Forms
{
    partial class ContractSingle
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
            this.numberLable = new System.Windows.Forms.Label();
            this.contractNumber = new System.Windows.Forms.TextBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.datesFromTo = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.targetVolume = new System.Windows.Forms.TextBox();
            this.actualVolume = new System.Windows.Forms.Label();
            this.processedVolume = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberLable
            // 
            this.numberLable.AutoSize = true;
            this.numberLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.numberLable.Location = new System.Drawing.Point(44, 0);
            this.numberLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberLable.Name = "numberLable";
            this.numberLable.Size = new System.Drawing.Size(94, 32);
            this.numberLable.TabIndex = 0;
            this.numberLable.Text = "Номер договора:";
            // 
            // contractNumber
            // 
            this.contractNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractNumber.Location = new System.Drawing.Point(142, 2);
            this.contractNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.Size = new System.Drawing.Size(179, 20);
            this.contractNumber.TabIndex = 1;
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Location = new System.Drawing.Point(142, 34);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(179, 20);
            this.dateFrom.TabIndex = 2;
            // 
            // datesFromTo
            // 
            this.datesFromTo.AutoSize = true;
            this.datesFromTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.datesFromTo.Location = new System.Drawing.Point(19, 32);
            this.datesFromTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datesFromTo.Name = "datesFromTo";
            this.datesFromTo.Size = new System.Drawing.Size(119, 32);
            this.datesFromTo.TabIndex = 3;
            this.datesFromTo.Text = "Действие договора с:";
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateToLabel.Location = new System.Drawing.Point(116, 64);
            this.dateToLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(22, 32);
            this.dateToLabel.TabIndex = 4;
            this.dateToLabel.Text = "по:";
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.Location = new System.Drawing.Point(142, 66);
            this.dateTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(179, 20);
            this.dateTo.TabIndex = 5;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.volumeLabel.Location = new System.Drawing.Point(95, 96);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(43, 32);
            this.volumeLabel.TabIndex = 6;
            this.volumeLabel.Text = "объем:";
            // 
            // targetVolume
            // 
            this.targetVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetVolume.Location = new System.Drawing.Point(142, 98);
            this.targetVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.targetVolume.Name = "targetVolume";
            this.targetVolume.Size = new System.Drawing.Size(179, 20);
            this.targetVolume.TabIndex = 7;
            // 
            // actualVolume
            // 
            this.actualVolume.AutoSize = true;
            this.actualVolume.Dock = System.Windows.Forms.DockStyle.Right;
            this.actualVolume.Location = new System.Drawing.Point(28, 128);
            this.actualVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.actualVolume.Name = "actualVolume";
            this.actualVolume.Size = new System.Drawing.Size(110, 32);
            this.actualVolume.TabIndex = 8;
            this.actualVolume.Text = "вывезенный объем:";
            // 
            // processedVolume
            // 
            this.processedVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedVolume.Location = new System.Drawing.Point(142, 130);
            this.processedVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.processedVolume.Name = "processedVolume";
            this.processedVolume.ReadOnly = true;
            this.processedVolume.Size = new System.Drawing.Size(179, 20);
            this.processedVolume.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.6409F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.3591F));
            this.tableLayoutPanel1.Controls.Add(this.numberLable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processedVolume, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.contractNumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.actualVolume, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.datesFromTo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.targetVolume, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateFrom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.volumeLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dateToLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 193);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(142, 162);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(179, 29);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Сохранить и закрыть";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ContractSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 193);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContractSingle";
            this.Text = "Новый договор";
            this.Load += new System.EventHandler(this.ContractSingle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numberLable;
        private System.Windows.Forms.TextBox contractNumber;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label datesFromTo;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TextBox targetVolume;
        private System.Windows.Forms.Label actualVolume;
        private System.Windows.Forms.TextBox processedVolume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button saveButton;
    }
}