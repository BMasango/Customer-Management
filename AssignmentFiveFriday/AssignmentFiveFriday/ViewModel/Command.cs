using AssignmentFiveFriday.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AssignmentFiveFriday.ViewModel
{
    public class Command : ICommand
    {
        public CustomerViewModel ViewModel { get; set; }
        public DBAccessLayer DBAccessControl { get; set; }

        public Command(CustomerViewModel viewModel)
        {
            ViewModel = viewModel;
            DBAccessControl = new DBAccessLayer();
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public virtual void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
