using AssignmentFiveFriday.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFiveFriday.ViewModel
{
    public class InsertUpdateCommand : Command
    {
        public InsertUpdateCommand(CustomerViewModel viewModel) : base(viewModel)
        {
        }

        public override void Execute(object parameter)
        {
            if (!ViewModel.DataSetSource.HasChanges())
                return;

            ViewModel.DataSetSource = DBAccessControl.ExecuteQueryHandler(ViewModel.DataSetSource, parameter.ToString());
        }
    }

    public class CustomerDetailRetriever : Command
    {
        public CustomerDetailRetriever(CustomerViewModel viewModel) : base(viewModel)
        {
        }

        public override void Execute(object parameter)
        {
            ViewModel.DataSetSource = DBAccessControl.GetAllCustomerDetails();
        }
    }
}
