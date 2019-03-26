namespace Accounting
{
    partial class Accounting
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
            this.Organizations = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Containers = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.platforms = new System.Windows.Forms.Button();
            this.drivers = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Organizations
            // 
            this.Organizations.Location = new System.Drawing.Point(3, 3);
            this.Organizations.Name = "Organizations";
            this.Organizations.Size = new System.Drawing.Size(136, 40);
            this.Organizations.TabIndex = 0;
            this.Organizations.Text = "Организации";
            this.Organizations.UseVisualStyleBackColor = true;
            this.Organizations.Click += new System.EventHandler(this.Organizations_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Controls.Add(this.Cars, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.drivers, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.platforms, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Containers, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Organizations, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.94296F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 46);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Containers
            // 
            this.Containers.Location = new System.Drawing.Point(144, 2);
            this.Containers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Containers.Name = "Containers";
            this.Containers.Size = new System.Drawing.Size(137, 41);
            this.Containers.TabIndex = 1;
            this.Containers.Text = "Контейнеры";
            this.Containers.UseVisualStyleBackColor = true;
            this.Containers.Click += new System.EventHandler(this.Containers_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(825, 410);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // platforms
            // 
            this.platforms.Location = new System.Drawing.Point(289, 3);
            this.platforms.Name = "platforms";
            this.platforms.Size = new System.Drawing.Size(136, 40);
            this.platforms.TabIndex = 2;
            this.platforms.Text = "Площадки";
            this.platforms.UseVisualStyleBackColor = true;
            this.platforms.Click += new System.EventHandler(this.platforms_Click);
            // 
            // drivers
            // 
            this.drivers.Location = new System.Drawing.Point(431, 3);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(136, 40);
            this.drivers.TabIndex = 3;
            this.drivers.Text = "Водители";
            this.drivers.UseVisualStyleBackColor = true;
            this.drivers.Click += new System.EventHandler(this.drivers_Click);
            // 
            // Cars
            // 
            this.Cars.Location = new System.Drawing.Point(574, 3);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(136, 40);
            this.Cars.TabIndex = 0;
            this.Cars.Text = "Автомобили";
            this.Cars.UseVisualStyleBackColor = true;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 461);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Accounting";
            this.Text = "Учет контейнеров";
            this.Load += new System.EventHandler(this.Accounting_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Accounting_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Accounting form = new Accounting();
            //form.ShowDialog();
            this.Close();
        }

        #endregion

        private System.Windows.Forms.Button Organizations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Containers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button drivers;
        private System.Windows.Forms.Button platforms;
    }
}

