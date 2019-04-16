namespace Accounting.Forms
{
    partial class Generic<T>
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
            this.saveData = new System.Windows.Forms.Button();
            this.commonData = new System.Windows.Forms.DataGridView();
            this.filter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.saveData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.commonData, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.filter, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(2, 2);
            this.saveData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(147, 26);
            this.saveData.TabIndex = 1;
            this.saveData.Text = "Сохранить и закрыть";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // commonData
            // 
            this.commonData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commonData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commonData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commonData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commonData.Location = new System.Drawing.Point(3, 55);
            this.commonData.Name = "commonData";
            this.commonData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.commonData.Size = new System.Drawing.Size(399, 254);
            this.commonData.TabIndex = 0;
            this.commonData.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.commonData_RowsAdded);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(2, 32);
            this.filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(148, 20);
            this.filter.TabIndex = 2;
            this.filter.TextChanged += new System.EventHandler(this.filter_TextChanged);
            // 
            // Generic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Generic";
            this.Text = "Generic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generic_FormClosing);
            this.Load += new System.EventHandler(this.Generic_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView commonData;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.TextBox filter;
    }
}