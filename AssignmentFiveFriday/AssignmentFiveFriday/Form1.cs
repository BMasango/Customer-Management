using AssignmentFiveFriday.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFiveFriday
{
    public partial class Form1 : Form
    {
        CustomerViewModel viewModel;
        BindingSource personalInformationSource;
        CustomerDetailEdit editForm;

        public Form1()
        {
            InitializeComponent();
            InitializeMainView();
        }

        private void InitializeMainView()
        {
            viewModel = new CustomerViewModel();
            personalInformationSource = new BindingSource();
            personalInformationSource.DataSource = viewModel.DataSetSource.Tables["Customer"];
            dgvCustomerDetails.DataSource = personalInformationSource;
            
            dgvCustomerDetails.SelectionChanged += DgvCustomerDetails_SelectionChanged;
            btnEdit.Click += new EventHandler((object sender, EventArgs e) => 
            {
                BtnEdit_Click();
            });
            btnNew.Click += new EventHandler((object sender, EventArgs e) => {
                BtnNew_Click();
            });
        }

        private void BtnNew_Click()
        {
            DataRow customerRow = viewModel.DataSetSource.Tables["Customer"].NewRow();
            customerRow["Name"] = "";
            customerRow["Longitude"] = "0";
            customerRow["Latitude"] = "0";
            viewModel.DataSetSource.Tables["Customer"].Rows.Add(customerRow);

            viewModel.SelectedCustomer = new Model.Customer(customerRow);
            editForm = new CustomerDetailEdit()
            {
                viewModel = this.viewModel
            };
            editForm.Show();
        }

        private void BtnEdit_Click()
        {
            if (dgvCustomerDetails.SelectedRows.Count == 0)
                return;

            int rowIndex = dgvCustomerDetails.CurrentRow.Index;
            DataTable dt = (DataTable)((BindingSource)dgvCustomerDetails.DataSource).DataSource;
            viewModel.SelectedCustomer = new Model.Customer(dt.Rows[rowIndex]);

            editForm = new CustomerDetailEdit()
            {
                viewModel = this.viewModel
            };
            editForm.Show();
        }

        private void DgvCustomerDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomerDetails.SelectedRows.Count == 0)
                return;

            btnEdit.Enabled = true;
        }
        
    }
}
