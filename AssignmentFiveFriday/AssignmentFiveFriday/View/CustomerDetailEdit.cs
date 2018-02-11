using AssignmentFiveFriday.Model;
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
    public partial class CustomerDetailEdit : Form
    {
        public CustomerViewModel viewModel;
        BindingSource contactDetailsSource;
        public CustomerDetailEdit()
        {
            InitializeComponent();
            contactDetailsSource = new BindingSource();
            this.Shown += CustomerDetailEdit_Shown1;
            this.dgvContactDetails.SelectionChanged += DgvContactDetails_SelectionChanged;

            this.btnContactNew.Click += new EventHandler((object sender, EventArgs e) =>
            {
                ClearNewContact();
            });
            this.btnContactAdd.Click += new EventHandler((object sender, EventArgs e) =>
            {
                AddNewContact();
            });
            btnSave.Click += new EventHandler((object sender, EventArgs e) =>
            {
                SaveUpdates();
            });
            
        }

        private void SaveUpdates()
        {
            contactDetailsSource.EndEdit();
            if (viewModel.DataSetSource.Tables["Customer"].DataSet.HasChanges() || viewModel.DataSetSource.Tables["CustomerContacts"].DataSet.HasChanges())
            {
                string filter = $"Name = '{viewModel.SelectedCustomer.Name}' AND Longitude = '{viewModel.SelectedCustomer.Longitude}' AND Latitude = '{viewModel.SelectedCustomer.Latitude}'";
                viewModel.Execute(btnSave.Tag, filter);
            }
                
            this.Hide();
        }

        private void AddNewContact()
        {
            contactDetailsSource.EndEdit();
            if (string.IsNullOrEmpty(txtSelectedContactNo.Text) && string.IsNullOrEmpty(txtSelectedEmail.Text))
                return;

            DataRow rowItem = viewModel.DataSetSource.Tables["CustomerContacts"].NewRow();
            rowItem["CustomerID"] = 0;
            rowItem["ContactNo"] = txtSelectedContactNo.Text;
            rowItem["Email"] = txtSelectedEmail.Text;
            viewModel.DataSetSource.Tables["CustomerContacts"].Rows.Add(rowItem);
            
            viewModel.SelectedCustomerContactResetBinding();
            if (string.IsNullOrEmpty(viewModel.SelectedCustomer.Row["ID"].ToString()))
            {
                viewModel.SelectedCustomer.ContactDetails.Add(new ContactDetail(rowItem));
            }
            contactDetailsSource.ResetBindings(true);
           
            btnContactAdd.Enabled = false;
            btnContactNew.Enabled = true;
        }

        private void ClearNewContact()
        {
            txtSelectedContactNo.Clear();
            txtSelectedEmail.Clear();
            btnContactAdd.Enabled = true;
            btnContactNew.Enabled = false;
        }

        private void DgvContactDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContactDetails.SelectedRows.Count < 1)
                return;
            
            txtSelectedContactNo.DataBindings.Add("Text", (ContactDetail)dgvContactDetails.SelectedRows[0].DataBoundItem, "ContactNo");
            txtSelectedEmail.DataBindings.Add("Text", (ContactDetail)dgvContactDetails.SelectedRows[0].DataBoundItem, "Email");
        }

        private void CustomerDetailEdit_Shown1(object sender, EventArgs e)
        {
            txtName.DataBindings.Add("Text", viewModel.SelectedCustomer, "Name");
            txtLongitude.DataBindings.Add("Text", viewModel.SelectedCustomer, "Longitude");
            txtLatitude.DataBindings.Add("Text", viewModel.SelectedCustomer, "Latitude");

            contactDetailsSource.DataSource = viewModel.SelectedCustomer.ContactDetails;
            dgvContactDetails.DataSource = contactDetailsSource;

            btnSave.Tag = viewModel.InsertUpdateCommand;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
