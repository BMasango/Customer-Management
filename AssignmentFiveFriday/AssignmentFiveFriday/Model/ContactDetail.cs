using System.Data;

namespace AssignmentFiveFriday.Model
{
    public class ContactDetail: PropertyChangeEvents
    {
        #region fields

        #endregion

        #region properties
        private DataRow Row { get; set; }

        public string Email
        {
            get
            {
                return (string)Row["Email"]; 
            }

            set
            {
                Row["Email"] = value;
                OnPropertyChange("Email");
            }
        }

        public string ContactNo
        {
            get
            {
                return (string)Row["ContactNo"];
            }

            set
            {
                Row["Email"] = value;
                OnPropertyChange("ContactNo");
            }
        }

        public int CustomerId
        {
            get
            {
                return (int)Row["CustomerID"];
            }

            set
            {
                Row["CustomerID"] = value;
                OnPropertyChange("CustomerId");
            }
        }
        #endregion

        #region constructor
        public ContactDetail(DataRow row) { this.Row = row; }
        #endregion
    }
}