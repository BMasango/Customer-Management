using AssignmentFiveFriday.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AssignmentFiveFriday.ViewModel
{
    public class CustomerViewModel : PropertyChangeEvents
    {
        #region fields
        private DataSet dataSetSource;
        private Customer selectedCustomer;
        private ICommand insertUpdateCommand;
        #endregion

        #region properties
        public Customer SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }
            set
            {
                if (value != null)
                {
                    selectedCustomer = value;
                    SelectedCustomerContactResetBinding();
                }
                OnPropertyChange("SelectedCustomer");
            }
        }

        public DataSet DataSetSource
        {
            get
            {
                if (dataSetSource == null)
                    dataSetSource = new DataSet();
                return dataSetSource;
            }

            set
            {
                dataSetSource = value;
                OnPropertyChange("DataSetSource");
            }
        }

        public ICommand InsertUpdateCommand
        {
            get
            {
                if (insertUpdateCommand == null)
                    insertUpdateCommand = new InsertUpdateCommand(this);
                return insertUpdateCommand;
            }

            set
            {
                insertUpdateCommand = value;
            }
        }
        #endregion

        #region constructor
        public CustomerViewModel()
        {
            new CustomerDetailRetriever(this).Execute(null);
        }
        #endregion


        #region methods
        public void Execute(object sender, object parameter)
        {
            ((ICommand)sender).Execute(parameter);
        }

        public void SelectedCustomerContactResetBinding()
        {
            if (!string.IsNullOrEmpty(SelectedCustomer.Row["ID"].ToString()))
            {
                DataRow[] contactsRows = DataSetSource.Tables["CustomerContacts"].Select("CustomerID = " + SelectedCustomer.Row["ID"].ToString());
                SelectedCustomer.ContactDetails.Clear();
                foreach (DataRow row in contactsRows)
                    SelectedCustomer.ContactDetails.Add(new ContactDetail(row));
            }
        }
        #endregion
    }
}
