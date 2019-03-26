﻿using System;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting.Forms
{
    public partial class OrgForm : Form
    {
        public OrgForm()
        {
            InitializeComponent();
        }

        private void OrgForm_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Size = Owner.Size;
            OrgGridView.AllowUserToAddRows = false;
            OrgGridView.AllowUserToDeleteRows = false;
            OrgGridView.ReadOnly = true;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            OrgGridView.Columns.Add(chk);
            // ReSharper disable once LocalizableElement
            chk.HeaderText = "Активный";
            chk.Name = "chk";
            RenewDataTable();
        }

        private void OrgGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = OrgGridView.CurrentRow;
            if (row != null)
            {
                var org = new Organization
                {
                    Id = (long) row.Cells[0].Value,
                    Name = (string) row.Cells[1].Value,
                    City = (string) row.Cells[2].Value,
                    Address = (string) row.Cells[3].Value,
                    Phone = (string) row.Cells[4].Value,
                    Active = (bool) row.Cells[5].Value
                };

                var form = new NewOrg(org);
                form.ShowDialog();
            }

            RenewDataTable();
        }

        private void NewCompany_Click(object sender, EventArgs e)
        {
            NewOrg form = new NewOrg();
            form.ShowDialog();
            Show();
            RenewDataTable();
        }


        private void RenewDataTable()
        {
            OrgGridView.Rows.Clear();
            var sql = new SqLiteHelper();
            var allOrg = sql.FindinTable<Organization>();
            foreach (var org in allOrg)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(OrgGridView);
                row.Cells[0].Value = org.Id;
                row.Cells[1].Value = org.Name;
                row.Cells[2].Value = org.City;
                row.Cells[3].Value = org.Address;
                row.Cells[4].Value = org.Phone;
                row.Cells[5].Value = org.Active;
                OrgGridView.Rows.Add(row);
            }

        }
    }
}
