namespace Accounting
{
    partial class NewOrg
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
            this.SuspendLayout();
            // 
            // OrgName
            // 
            this.OrgName.Location = new System.Drawing.Point(97, 11);
            this.OrgName.Name = "OrgName";
            this.OrgName.Size = new System.Drawing.Size(205, 20);
            this.OrgName.TabIndex = 0;
            // 
            // OrgNameLabel
            // 
            this.OrgNameLabel.AutoSize = true;
            this.OrgNameLabel.Location = new System.Drawing.Point(5, 11);
            this.OrgNameLabel.Name = "OrgNameLabel";
            this.OrgNameLabel.Size = new System.Drawing.Size(86, 13);
            this.OrgNameLabel.TabIndex = 1;
            this.OrgNameLabel.Text = "Наименование:";
            // 
            // OrgCityLabel
            // 
            this.OrgCityLabel.AutoSize = true;
            this.OrgCityLabel.Location = new System.Drawing.Point(51, 45);
            this.OrgCityLabel.Name = "OrgCityLabel";
            this.OrgCityLabel.Size = new System.Drawing.Size(40, 13);
            this.OrgCityLabel.TabIndex = 2;
            this.OrgCityLabel.Text = "Город:";
            // 
            // OrgAddressLabel
            // 
            this.OrgAddressLabel.AutoSize = true;
            this.OrgAddressLabel.Location = new System.Drawing.Point(50, 91);
            this.OrgAddressLabel.Name = "OrgAddressLabel";
            this.OrgAddressLabel.Size = new System.Drawing.Size(41, 13);
            this.OrgAddressLabel.TabIndex = 3;
            this.OrgAddressLabel.Text = "Адрес:";
            this.OrgAddressLabel.Click += new System.EventHandler(this.OrgAddressLabel_Click);
            // 
            // OrgPhoneLabel
            // 
            this.OrgPhoneLabel.AutoSize = true;
            this.OrgPhoneLabel.Location = new System.Drawing.Point(36, 136);
            this.OrgPhoneLabel.Name = "OrgPhoneLabel";
            this.OrgPhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.OrgPhoneLabel.TabIndex = 4;
            this.OrgPhoneLabel.Text = "Телефон:";
            // 
            // OrgCommentLabel
            // 
            this.OrgCommentLabel.AutoSize = true;
            this.OrgCommentLabel.Location = new System.Drawing.Point(323, 14);
            this.OrgCommentLabel.Name = "OrgCommentLabel";
            this.OrgCommentLabel.Size = new System.Drawing.Size(80, 13);
            this.OrgCommentLabel.TabIndex = 5;
            this.OrgCommentLabel.Text = "Комментарий:";
            // 
            // OrgActiveLabel
            // 
            this.OrgActiveLabel.AutoSize = true;
            this.OrgActiveLabel.Location = new System.Drawing.Point(546, 14);
            this.OrgActiveLabel.Name = "OrgActiveLabel";
            this.OrgActiveLabel.Size = new System.Drawing.Size(60, 13);
            this.OrgActiveLabel.TabIndex = 6;
            this.OrgActiveLabel.Text = "Активный:";
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(97, 45);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(205, 20);
            this.City.TabIndex = 7;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(97, 91);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(205, 20);
            this.Address.TabIndex = 8;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(97, 136);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(205, 20);
            this.Phone.TabIndex = 9;
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(326, 45);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(301, 111);
            this.Comment.TabIndex = 10;
            this.Comment.Text = "";
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Location = new System.Drawing.Point(612, 13);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(15, 14);
            this.Active.TabIndex = 11;
            this.Active.UseVisualStyleBackColor = true;
            // 
            // SaveData
            // 
            this.SaveData.Location = new System.Drawing.Point(12, 173);
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(178, 36);
            this.SaveData.TabIndex = 12;
            this.SaveData.Text = "Сохранить";
            this.SaveData.UseVisualStyleBackColor = true;
            this.SaveData.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // NewOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 221);
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
            this.Name = "NewOrg";
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
    }
}