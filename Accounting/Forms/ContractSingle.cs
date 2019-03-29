using System;
using System.Globalization;
using System.Windows.Forms;
using Accounting.Models;

namespace Accounting.Forms
{
    public partial class ContractSingle : Form
    {
        protected Contract Contract;
        protected Organization Org;
        protected bool Edit;
        public ContractSingle(Contract contract)
        {
            if (contract != null)
            {
                Edit = true;
                Contract = contract;
            }
            InitializeComponent();
        }

        public ContractSingle(Organization org)
        {
            if (org != null)
            {
                Edit = false;
                Org = org;
            }
            InitializeComponent();
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void ContractSingle_Load(object sender, EventArgs e)
        {
            if (Edit)
            {
                contractNumber.Text = Contract.ContractNumber;
                dateFrom.Value = Contract.FromDate;
                dateTo.Value = Contract.ToDate;
                targetVolume.Text = Contract.TargetVolume.ToString(CultureInfo.InvariantCulture);
                processedVolume.Text = Contract.ProcessedVolume.ToString(CultureInfo.InvariantCulture);
                Text = $@"Редактирование договора '{Contract.ContractNumber}'";
            }
            else
            {
                processedVolume.Text = @"0";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var sql = new SqLiteHelper();
            Single.TryParse(targetVolume.Text, out float target);
            Single.TryParse(processedVolume.Text, out float processed);
            var newCont = new Contract
            {
                Id = Edit ? Contract.Id : 0,
                ContractNumber = contractNumber.Text,
                FromDate = dateFrom.Value,
                ToDate = dateTo.Value,
                TargetVolume = target,
                ProcessedVolume = processed,
                Organization = Edit ? Contract.Organization : Org.Id
            };

            int result;

            if (!Edit)
            {
                result = sql.WriteToDb(newCont);
                
            }
            else result= sql.UpdateDb(newCont);

            if (result == 1)
            {
                if (dateFrom.Value < DateTime.Today && DateTime.Today< dateTo.Value)
                {
                    sql.UpdateRecord<Organization>(newCont.Organization, "Active", "1");
                }
            }

            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
