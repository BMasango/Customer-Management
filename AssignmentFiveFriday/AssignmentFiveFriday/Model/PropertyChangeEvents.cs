using System.ComponentModel;

namespace AssignmentFiveFriday.Model
{
    public class PropertyChangeEvents : INotifyPropertyChanged
    {
        public void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}