namespace Accounting.Forms
{
    partial class NewRegistry
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
            this.selectOrganization = new System.Windows.Forms.ComboBox();
            this.selectOrglabel = new System.Windows.Forms.Label();
            this.contractLable = new System.Windows.Forms.Label();
            this.contractSelect = new System.Windows.Forms.ComboBox();
            this.selectPlatformLabel = new System.Windows.Forms.Label();
            this.selectPlatform = new System.Windows.Forms.ComboBox();
            this.selectedContainer = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.TextBox();
            this.targetVolumeLabel = new System.Windows.Forms.Label();
            this.targetVolume = new System.Windows.Forms.TextBox();
            this.proccedVolumeLabel = new System.Windows.Forms.Label();
            this.processedVolume = new System.Windows.Forms.TextBox();
            this.processDate = new System.Windows.Forms.DateTimePicker();
            this.InputDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.carLabel = new System.Windows.Forms.Label();
            this.selectCar = new System.Windows.Forms.ComboBox();
            this.selectContainerLabel = new System.Windows.Forms.Label();
            this.selectContainer = new System.Windows.Forms.ComboBox();
            this.driverLabel = new System.Windows.Forms.Label();
            this.selectDriver = new System.Windows.Forms.ComboBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.quntityLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveNewRegistry = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectOrganization
            // 
            this.selectOrganization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectOrganization.FormattingEnabled = true;
            this.selectOrganization.Location = new System.Drawing.Point(3, 25);
            this.selectOrganization.Name = "selectOrganization";
            this.selectOrganization.Size = new System.Drawing.Size(168, 21);
            this.selectOrganization.TabIndex = 0;
            this.selectOrganization.SelectedValueChanged += new System.EventHandler(this.selectOrganization_SelectedValueChanged);
            // 
            // selectOrglabel
            // 
            this.selectOrglabel.AutoSize = true;
            this.selectOrglabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectOrglabel.Location = new System.Drawing.Point(3, 9);
            this.selectOrglabel.Name = "selectOrglabel";
            this.selectOrglabel.Size = new System.Drawing.Size(168, 13);
            this.selectOrglabel.TabIndex = 1;
            this.selectOrglabel.Text = "Выбирите организацию:";
            // 
            // contractLable
            // 
            this.contractLable.AutoSize = true;
            this.contractLable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contractLable.Location = new System.Drawing.Point(3, 53);
            this.contractLable.Name = "contractLable";
            this.contractLable.Size = new System.Drawing.Size(168, 13);
            this.contractLable.TabIndex = 2;
            this.contractLable.Text = "Выбирите договор:";
            // 
            // contractSelect
            // 
            this.contractSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contractSelect.FormattingEnabled = true;
            this.contractSelect.Location = new System.Drawing.Point(3, 69);
            this.contractSelect.Name = "contractSelect";
            this.contractSelect.Size = new System.Drawing.Size(168, 21);
            this.contractSelect.TabIndex = 3;
            this.contractSelect.SelectedValueChanged += new System.EventHandler(this.contractSelect_SelectedValueChanged);
            // 
            // selectPlatformLabel
            // 
            this.selectPlatformLabel.AutoSize = true;
            this.selectPlatformLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectPlatformLabel.Location = new System.Drawing.Point(3, 97);
            this.selectPlatformLabel.Name = "selectPlatformLabel";
            this.selectPlatformLabel.Size = new System.Drawing.Size(168, 13);
            this.selectPlatformLabel.TabIndex = 4;
            this.selectPlatformLabel.Text = "Выбирите площадку";
            // 
            // selectPlatform
            // 
            this.selectPlatform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectPlatform.FormattingEnabled = true;
            this.selectPlatform.Location = new System.Drawing.Point(3, 113);
            this.selectPlatform.Name = "selectPlatform";
            this.selectPlatform.Size = new System.Drawing.Size(168, 21);
            this.selectPlatform.TabIndex = 5;
            this.selectPlatform.SelectedValueChanged += new System.EventHandler(this.selectPlatform_SelectedValueChanged);
            // 
            // selectedContainer
            // 
            this.selectedContainer.AutoSize = true;
            this.selectedContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectedContainer.Location = new System.Drawing.Point(351, 97);
            this.selectedContainer.Name = "selectedContainer";
            this.selectedContainer.Size = new System.Drawing.Size(168, 13);
            this.selectedContainer.TabIndex = 6;
            this.selectedContainer.Text = "Объем контейнера";
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(351, 113);
            this.container.Name = "container";
            this.container.ReadOnly = true;
            this.container.Size = new System.Drawing.Size(168, 20);
            this.container.TabIndex = 8;
            // 
            // targetVolumeLabel
            // 
            this.targetVolumeLabel.AutoSize = true;
            this.targetVolumeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.targetVolumeLabel.Location = new System.Drawing.Point(177, 53);
            this.targetVolumeLabel.Name = "targetVolumeLabel";
            this.targetVolumeLabel.Size = new System.Drawing.Size(168, 13);
            this.targetVolumeLabel.TabIndex = 10;
            this.targetVolumeLabel.Text = "Объем по договору:";
            // 
            // targetVolume
            // 
            this.targetVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetVolume.Location = new System.Drawing.Point(177, 69);
            this.targetVolume.Name = "targetVolume";
            this.targetVolume.ReadOnly = true;
            this.targetVolume.Size = new System.Drawing.Size(168, 20);
            this.targetVolume.TabIndex = 11;
            // 
            // proccedVolumeLabel
            // 
            this.proccedVolumeLabel.AutoSize = true;
            this.proccedVolumeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.proccedVolumeLabel.Location = new System.Drawing.Point(351, 53);
            this.proccedVolumeLabel.Name = "proccedVolumeLabel";
            this.proccedVolumeLabel.Size = new System.Drawing.Size(168, 13);
            this.proccedVolumeLabel.TabIndex = 12;
            this.proccedVolumeLabel.Text = "Вывезенный объем:";
            // 
            // processedVolume
            // 
            this.processedVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processedVolume.Location = new System.Drawing.Point(351, 69);
            this.processedVolume.Name = "processedVolume";
            this.processedVolume.ReadOnly = true;
            this.processedVolume.Size = new System.Drawing.Size(168, 20);
            this.processedVolume.TabIndex = 13;
            // 
            // processDate
            // 
            this.processDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processDate.Location = new System.Drawing.Point(177, 25);
            this.processDate.Name = "processDate";
            this.processDate.Size = new System.Drawing.Size(168, 20);
            this.processDate.TabIndex = 14;
            this.processDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // InputDate
            // 
            this.InputDate.AutoSize = true;
            this.InputDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputDate.Location = new System.Drawing.Point(177, 9);
            this.InputDate.Name = "InputDate";
            this.InputDate.Size = new System.Drawing.Size(168, 13);
            this.InputDate.TabIndex = 15;
            this.InputDate.Text = "Дата проведения:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.selectOrglabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.processedVolume, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.processDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.proccedVolumeLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.InputDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.targetVolume, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectOrganization, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.targetVolumeLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.contractLable, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.contractSelect, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.selectPlatformLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.selectPlatform, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.carLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.selectCar, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.selectedContainer, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.container, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.selectContainerLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.selectContainer, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.driverLabel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.selectDriver, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.quantity, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.quntityLabel, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 227);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.carLabel.Location = new System.Drawing.Point(3, 185);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(168, 13);
            this.carLabel.TabIndex = 17;
            this.carLabel.Text = "Выбирите машину:";
            // 
            // selectCar
            // 
            this.selectCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectCar.FormattingEnabled = true;
            this.selectCar.Location = new System.Drawing.Point(3, 201);
            this.selectCar.Name = "selectCar";
            this.selectCar.Size = new System.Drawing.Size(168, 21);
            this.selectCar.TabIndex = 19;
            // 
            // selectContainerLabel
            // 
            this.selectContainerLabel.AutoSize = true;
            this.selectContainerLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.selectContainerLabel.Location = new System.Drawing.Point(177, 97);
            this.selectContainerLabel.Name = "selectContainerLabel";
            this.selectContainerLabel.Size = new System.Drawing.Size(168, 13);
            this.selectContainerLabel.TabIndex = 20;
            this.selectContainerLabel.Text = "Выберете контейнер";
            // 
            // selectContainer
            // 
            this.selectContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectContainer.FormattingEnabled = true;
            this.selectContainer.Location = new System.Drawing.Point(177, 113);
            this.selectContainer.Name = "selectContainer";
            this.selectContainer.Size = new System.Drawing.Size(168, 21);
            this.selectContainer.TabIndex = 21;
            this.selectContainer.SelectedValueChanged += new System.EventHandler(this.selectContainer_SelectedValueChanged);
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.driverLabel.Location = new System.Drawing.Point(177, 185);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(168, 13);
            this.driverLabel.TabIndex = 16;
            this.driverLabel.Text = "Выберети водителя:";
            // 
            // selectDriver
            // 
            this.selectDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDriver.FormattingEnabled = true;
            this.selectDriver.Location = new System.Drawing.Point(177, 201);
            this.selectDriver.Name = "selectDriver";
            this.selectDriver.Size = new System.Drawing.Size(168, 21);
            this.selectDriver.TabIndex = 18;
            // 
            // quantity
            // 
            this.quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantity.Location = new System.Drawing.Point(351, 157);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(168, 20);
            this.quantity.TabIndex = 23;
            this.quantity.Visible = false;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // quntityLabel
            // 
            this.quntityLabel.AutoSize = true;
            this.quntityLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quntityLabel.Location = new System.Drawing.Point(351, 141);
            this.quntityLabel.Name = "quntityLabel";
            this.quntityLabel.Size = new System.Drawing.Size(168, 13);
            this.quntityLabel.TabIndex = 22;
            this.quntityLabel.Text = "Количество:";
            this.quntityLabel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveNewRegistry, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 227);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(522, 35);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // saveNewRegistry
            // 
            this.saveNewRegistry.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveNewRegistry.Location = new System.Drawing.Point(351, 3);
            this.saveNewRegistry.Name = "saveNewRegistry";
            this.saveNewRegistry.Size = new System.Drawing.Size(168, 29);
            this.saveNewRegistry.TabIndex = 0;
            this.saveNewRegistry.Text = "Сохранить";
            this.saveNewRegistry.UseVisualStyleBackColor = true;
            this.saveNewRegistry.Click += new System.EventHandler(this.saveNewRegistry_Click);
            // 
            // NewRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 262);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewRegistry";
            this.Text = "Вывоз контейнера";
            this.Load += new System.EventHandler(this.NewRegistry_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox selectOrganization;
        private System.Windows.Forms.Label selectOrglabel;
        private System.Windows.Forms.Label contractLable;
        private System.Windows.Forms.ComboBox contractSelect;
        private System.Windows.Forms.Label selectPlatformLabel;
        private System.Windows.Forms.ComboBox selectPlatform;
        private System.Windows.Forms.Label selectedContainer;
        private System.Windows.Forms.TextBox container;
        private System.Windows.Forms.Label targetVolumeLabel;
        private System.Windows.Forms.TextBox targetVolume;
        private System.Windows.Forms.Label proccedVolumeLabel;
        private System.Windows.Forms.TextBox processedVolume;
        private System.Windows.Forms.DateTimePicker processDate;
        private System.Windows.Forms.Label InputDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.ComboBox selectDriver;
        private System.Windows.Forms.ComboBox selectCar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button saveNewRegistry;
        private System.Windows.Forms.Label selectContainerLabel;
        private System.Windows.Forms.ComboBox selectContainer;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label quntityLabel;
    }
}