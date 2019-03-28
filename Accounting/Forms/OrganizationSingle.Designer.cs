namespace Accounting.Forms
{
    partial class OrganizationSingle
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
            this.OrgName = new System.Windows.Forms.TextBox();
            this.OrgNameLabel = new System.Windows.Forms.Label();
            this.OrgCityLabel = new System.Windows.Forms.Label();
            this.OrgAddressLabel = new System.Windows.Forms.Label();
            this.OrgPhoneLabel = new System.Windows.Forms.Label();
            this.OrgCommentLabel = new System.Windows.Forms.Label();
            this.OrgActiveLabel = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.RichTextBox();
            this.Active = new System.Windows.Forms.CheckBox();
            this.SaveData = new System.Windows.Forms.Button();
            this.contracts = new System.Windows.Forms.Button();
            this.containers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrgName
            // 
            this.OrgName.Location = new System.Drawing.Point(129, 14);
            this.OrgName.Margin = new System.Windows.Forms.Padding(4);
            this.OrgName.Name = "OrgName";
            this.OrgName.Size = new System.Drawing.Size(272, 22);
            this.OrgName.TabIndex = 0;
            // 
            // OrgNameLabel
            // 
            this.OrgNameLabel.AutoSize = true;
            this.OrgNameLabel.Location = new System.Drawing.Point(7, 14);
            this.OrgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrgNameLabel.Name = "OrgNameLabel";
            this.OrgNameLabel.Size = new System.Drawing.Size(110, 17);
            this.OrgNameLabel.TabIndex = 1;
            this.OrgNameLabel.Text = "Наименование:";
            // 
            // OrgCityLabel
            // 
            this.OrgCityLabel.AutoSize = true;
            this.OrgCityLabel.Location = new System.Drawing.Point(68, 55);
            this.OrgCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrgCityLabel.Name = "OrgCityLabel";
            this.OrgCityLabel.Size = new System.Drawing.Size(52, 17);
            this.OrgCityLabel.TabIndex = 2;
            this.OrgCityLabel.Text = "Город:";
            // 
            // OrgAddressLabel
            // 
            this.OrgAddressLabel.AutoSize = true;
            this.OrgAddressLabel.Location = new System.Drawing.Point(67, 112);
            this.OrgAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrgAddressLabel.Name = "OrgAddressLabel";
            this.OrgAddressLabel.Size = new System.Drawing.Size(52, 17);
            this.OrgAddressLabel.TabIndex = 3;
            this.OrgAddressLabel.Text = "Адрес:";
            this.OrgAddressLabel.Click += new System.EventHandler(this.OrgAddressLabel_Click);
            // 
            // OrgPhoneLabel
            // 
            this.OrgPhoneLabel.AutoSize = true;
            this.OrgPhoneLabel.Location = new System.Drawing.Point(48, 167);
            this.OrgPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrgPhoneLabel.Name = "OrgPhoneLabel";
            this.OrgPhoneLabel.Size = new System.Drawing.Size(72, 17);
            this.OrgPhoneLabel.TabIndex = 4;
            this.OrgPhoneLabel.Text = "Телефон:";
            // 
            // OrgCommentLabel
            // 
            this.OrgCommentLabel.AutoSize = true;
            this.OrgCommentLabel.Location = new System.Drawing.Point(431, 17);
            this.OrgCommentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrgCommentLabel.Name = "OrgCommentLabel";
            this.OrgCommentLabel.Size = new System.Drawing.Size(102, 17);
            this.OrgCommentLabel.TabIndex = 5;
            this.OrgCommentLabel.Text = "Комментарий:";
            // 
            // OrgActiveLabel
            // 
            this.OrgActiveLabel.AutoSize = true;
            this.OrgActiveLabel.Location = new System.Drawing.Point(728, 17);
            this.OrgActiveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrgActiveLabel.Name = "OrgActiveLabel";
            this.OrgActiveLabel.Size = new System.Drawing.Size(76, 17);
            this.OrgActiveLabel.TabIndex = 6;
            this.OrgActiveLabel.Text = "Активный:";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(129, 55);
            this.City.Margin = new System.Windows.Forms.Padding(4);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(272, 22);
            this.City.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(129, 112);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(272, 22);
            this.Address.TabIndex = 8;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(129, 167);
            this.Phone.Margin = new System.Windows.Forms.Padding(4);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(272, 22);
            this.Phone.TabIndex = 9;
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(435, 55);
            this.Comment.Margin = new System.Windows.Forms.Padding(4);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(400, 136);
            this.Comment.TabIndex = 10;
            this.Comment.Text = "";
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Location = new System.Drawing.Point(816, 16);
            this.Active.Margin = new System.Windows.Forms.Padding(4);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(18, 17);
            this.Active.TabIndex = 11;
            this.Active.UseVisualStyleBackColor = true;
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(16, 213);
            this.SaveData.Margin = new System.Windows.Forms.Padding(4);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(237, 44);
            this.SaveData.TabIndex = 12;
            this.SaveData.Text = "Сохранить";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // contracts
            // 
            this.contracts.Location = new System.Drawing.Point(308, 213);
            this.contracts.Name = "contracts";
            this.contracts.Size = new System.Drawing.Size(237, 44);
            this.contracts.TabIndex = 13;
            this.contracts.Text = "Договора";
            this.contracts.UseVisualStyleBackColor = true;
            // 
            // containers
            // 
            this.containers.Location = new System.Drawing.Point(597, 213);
            this.containers.Name = "containers";
            this.containers.Size = new System.Drawing.Size(237, 44);
            this.containers.TabIndex = 14;
            this.containers.Text = "Контейнера";
            this.containers.UseVisualStyleBackColor = true;
            this.containers.Click += new System.EventHandler(this.containers_Click);
            // 
            // OrganizationSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 272);
            this.Controls.Add(this.containers);
            this.Controls.Add(this.contracts);
            this.Controls.Add(this.SaveData);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.City);
            this.Controls.Add(this.OrgActiveLabel);
            this.Controls.Add(this.OrgCommentLabel);
            this.Controls.Add(this.OrgPhoneLabel);
            this.Controls.Add(this.OrgAddressLabel);
            this.Controls.Add(this.OrgCityLabel);
            this.Controls.Add(this.OrgNameLabel);
            this.Controls.Add(this.OrgName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrganizationSingle";
            this.Text = "Новая организация";
            this.Load += new System.EventHandler(this.NewOrg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrgName;
        private System.Windows.Forms.Label OrgNameLabel;
        private System.Windows.Forms.Label OrgCityLabel;
        private System.Windows.Forms.Label OrgAddressLabel;
        private System.Windows.Forms.Label OrgPhoneLabel;
        private System.Windows.Forms.Label OrgCommentLabel;
        private System.Windows.Forms.Label OrgActiveLabel;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.RichTextBox Comment;
        private System.Windows.Forms.CheckBox Active;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.Button contracts;
        private System.Windows.Forms.Button containers;
    }
}