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
            this.Cars = new System.Windows.Forms.Button();
            this.drivers = new System.Windows.Forms.Button();
            this.platforms = new System.Windows.Forms.Button();
            this.Containers = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.registry = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataRegistry = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.orgFilterLabel = new System.Windows.Forms.Label();
            this.orgFilter = new System.Windows.Forms.TextBox();
            this.dataFromLabel = new System.Windows.Forms.Label();
            this.dataToLable = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.newButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.contQueue = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.containesQueueData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteFromQueue = new System.Windows.Forms.Button();
            this.MakeProccesed = new System.Windows.Forms.Button();
            this.MakeUnProccesed = new System.Windows.Forms.Button();
            this.IdQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueuePlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueContType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daypast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.registry.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegistry)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.contQueue.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containesQueueData)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.94296F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 46);
            this.tableLayoutPanel1.TabIndex = 1;
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
            // Containers
            // 
            this.Containers.Location = new System.Drawing.Point(144, 2);
            this.Containers.Margin = new System.Windows.Forms.Padding(2);
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
            this.tableLayoutPanel2.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(825, 410);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.registry);
            this.tabControl.Controls.Add(this.contQueue);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(819, 404);
            this.tabControl.TabIndex = 0;
            // 
            // registry
            // 
            this.registry.Controls.Add(this.tableLayoutPanel4);
            this.registry.Controls.Add(this.tableLayoutPanel3);
            this.registry.Location = new System.Drawing.Point(4, 22);
            this.registry.Name = "registry";
            this.registry.Size = new System.Drawing.Size(811, 378);
            this.registry.TabIndex = 0;
            this.registry.Text = "Реестр";
            this.registry.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dataRegistry, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 54);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(811, 324);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // dataRegistry
            // 
            this.dataRegistry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRegistry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegistry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRegistry.Location = new System.Drawing.Point(3, 3);
            this.dataRegistry.Name = "dataRegistry";
            this.dataRegistry.ReadOnly = true;
            this.dataRegistry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRegistry.Size = new System.Drawing.Size(805, 318);
            this.dataRegistry.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.orgFilterLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.orgFilter, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataFromLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dataToLable, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateFrom, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.dateTo, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.newButton, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.removeButton, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(811, 54);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // orgFilterLabel
            // 
            this.orgFilterLabel.AutoSize = true;
            this.orgFilterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.orgFilterLabel.Location = new System.Drawing.Point(3, 14);
            this.orgFilterLabel.Name = "orgFilterLabel";
            this.orgFilterLabel.Size = new System.Drawing.Size(156, 13);
            this.orgFilterLabel.TabIndex = 0;
            this.orgFilterLabel.Text = "Фильтр по организациям";
            // 
            // orgFilter
            // 
            this.orgFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgFilter.Location = new System.Drawing.Point(3, 30);
            this.orgFilter.Name = "orgFilter";
            this.orgFilter.Size = new System.Drawing.Size(156, 20);
            this.orgFilter.TabIndex = 1;
            this.orgFilter.TextChanged += new System.EventHandler(this.orgFilter_TextChanged);
            // 
            // dataFromLabel
            // 
            this.dataFromLabel.AutoSize = true;
            this.dataFromLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataFromLabel.Location = new System.Drawing.Point(165, 14);
            this.dataFromLabel.Name = "dataFromLabel";
            this.dataFromLabel.Size = new System.Drawing.Size(156, 13);
            this.dataFromLabel.TabIndex = 2;
            this.dataFromLabel.Text = "Период с:";
            // 
            // dataToLable
            // 
            this.dataToLable.AutoSize = true;
            this.dataToLable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataToLable.Location = new System.Drawing.Point(327, 14);
            this.dataToLable.Name = "dataToLable";
            this.dataToLable.Size = new System.Drawing.Size(156, 13);
            this.dataToLable.TabIndex = 3;
            this.dataToLable.Text = "Период По:";
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Location = new System.Drawing.Point(165, 30);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(156, 20);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.Location = new System.Drawing.Point(327, 30);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(156, 20);
            this.dateTo.TabIndex = 5;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // newButton
            // 
            this.newButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newButton.Location = new System.Drawing.Point(489, 30);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(156, 21);
            this.newButton.TabIndex = 6;
            this.newButton.Text = "Создать";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(651, 30);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(157, 21);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // contQueue
            // 
            this.contQueue.Controls.Add(this.tableLayoutPanel6);
            this.contQueue.Controls.Add(this.tableLayoutPanel5);
            this.contQueue.Location = new System.Drawing.Point(4, 22);
            this.contQueue.Name = "contQueue";
            this.contQueue.Size = new System.Drawing.Size(811, 378);
            this.contQueue.TabIndex = 1;
            this.contQueue.Text = "Очередь контейнеров";
            this.contQueue.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.containesQueueData, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(811, 340);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // containesQueueData
            // 
            this.containesQueueData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.containesQueueData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.containesQueueData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdQueue,
            this.IdCont,
            this.QueueOrg,
            this.QueuePlatform,
            this.QueueContType,
            this.Volume,
            this.Daypast,
            this.Processed});
            this.containesQueueData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containesQueueData.Location = new System.Drawing.Point(3, 3);
            this.containesQueueData.Name = "containesQueueData";
            this.containesQueueData.ReadOnly = true;
            this.containesQueueData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.containesQueueData.Size = new System.Drawing.Size(805, 334);
            this.containesQueueData.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.DeleteFromQueue, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.MakeProccesed, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.MakeUnProccesed, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(811, 38);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // DeleteFromQueue
            // 
            this.DeleteFromQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteFromQueue.Location = new System.Drawing.Point(3, 3);
            this.DeleteFromQueue.Name = "DeleteFromQueue";
            this.DeleteFromQueue.Size = new System.Drawing.Size(196, 32);
            this.DeleteFromQueue.TabIndex = 0;
            this.DeleteFromQueue.Text = "Удалить";
            this.DeleteFromQueue.UseVisualStyleBackColor = true;
            this.DeleteFromQueue.Click += new System.EventHandler(this.DeleteFromQueue_Click);
            // 
            // MakeProccesed
            // 
            this.MakeProccesed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakeProccesed.Location = new System.Drawing.Point(205, 3);
            this.MakeProccesed.Name = "MakeProccesed";
            this.MakeProccesed.Size = new System.Drawing.Size(196, 32);
            this.MakeProccesed.TabIndex = 1;
            this.MakeProccesed.Text = "Вывезен";
            this.MakeProccesed.UseVisualStyleBackColor = true;
            this.MakeProccesed.Click += new System.EventHandler(this.MakeProccesed_Click);
            // 
            // MakeUnProccesed
            // 
            this.MakeUnProccesed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakeUnProccesed.Location = new System.Drawing.Point(407, 3);
            this.MakeUnProccesed.Name = "MakeUnProccesed";
            this.MakeUnProccesed.Size = new System.Drawing.Size(196, 32);
            this.MakeUnProccesed.TabIndex = 2;
            this.MakeUnProccesed.Text = "Не вывезен";
            this.MakeUnProccesed.UseVisualStyleBackColor = true;
            this.MakeUnProccesed.Click += new System.EventHandler(this.MakeUnProccesed_Click);
            // 
            // IdQueue
            // 
            this.IdQueue.HeaderText = "Id";
            this.IdQueue.Name = "IdQueue";
            this.IdQueue.ReadOnly = true;
            this.IdQueue.Visible = false;
            // 
            // IdCont
            // 
            this.IdCont.HeaderText = "IdCont";
            this.IdCont.Name = "IdCont";
            this.IdCont.ReadOnly = true;
            this.IdCont.Visible = false;
            // 
            // QueueOrg
            // 
            this.QueueOrg.HeaderText = "Организация";
            this.QueueOrg.Name = "QueueOrg";
            this.QueueOrg.ReadOnly = true;
            // 
            // QueuePlatform
            // 
            this.QueuePlatform.HeaderText = "Платформа";
            this.QueuePlatform.Name = "QueuePlatform";
            this.QueuePlatform.ReadOnly = true;
            // 
            // QueueContType
            // 
            this.QueueContType.HeaderText = "Тип конейнера";
            this.QueueContType.Name = "QueueContType";
            this.QueueContType.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Объем";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // Daypast
            // 
            this.Daypast.HeaderText = "Задержка";
            this.Daypast.Name = "Daypast";
            this.Daypast.ReadOnly = true;
            // 
            // Processed
            // 
            this.Processed.HeaderText = "Вывезен";
            this.Processed.Name = "Processed";
            this.Processed.ReadOnly = true;
            this.Processed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Processed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.registry.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRegistry)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.contQueue.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.containesQueueData)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage registry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage contQueue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridView dataRegistry;
        private System.Windows.Forms.Label orgFilterLabel;
        private System.Windows.Forms.TextBox orgFilter;
        private System.Windows.Forms.Label dataFromLabel;
        private System.Windows.Forms.Label dataToLable;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView containesQueueData;
        private System.Windows.Forms.Button DeleteFromQueue;
        private System.Windows.Forms.Button MakeProccesed;
        private System.Windows.Forms.Button MakeUnProccesed;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCont;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueueOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueuePlatform;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueueContType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daypast;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Processed;
    }
}

