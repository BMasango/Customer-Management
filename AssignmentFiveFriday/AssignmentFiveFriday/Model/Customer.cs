using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFiveFriday.Model
{
    public class Customer: PropertyChangeEvents
    {
        #region fields
        private BindingList<ContactDetail> contactDetails = new BindingList<ContactDetail>();
        #endregion

        #region Properties
        public DataRow Row {
            get;
            private set;
        }

        public string Name
        {
            get
            {
                return (string)Row["Name"];
            }

            set
            {
                Row["Name"] = value;
                OnPropertyChange("Name");
            }
        }

        public string Longitude
        {
            get
            {
                return (string)Row["Longitude"];
            }

            set
            {
                Row["Longitude"] = value;
                OnPropertyChange("Longitude");
            }
        }

        public string Latitude
        {
            get
            {
                return (string)Row["Latitude"];
            }

            set
            {
                Row["Latitude"] = value;
                OnPropertyChange("Latitude");
            }
        }

        internal BindingList<ContactDetail> ContactDetails
        {
            get
            {
                return contactDetails;
            }

            set
            {
                contactDetails = value;
                OnPropertyChange("ContactDetails");
            }
        }
        #endregion

        #region constructor
        public Customer(DataRow row) { this.Row = row; }
        #endregion
    }
}
