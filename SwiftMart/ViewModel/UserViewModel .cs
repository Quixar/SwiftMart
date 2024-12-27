using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SwiftMart.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private string lastName;
        private string email;
        private string password;
        private string address;
        private string role;

        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public string Lastname
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public string Address
        {
            get => address;
            set => SetProperty(ref address, value);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public string Role
        {
            get => role;
            set => SetProperty(ref role, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        private void Login(object parameter)
        {
            
        }

        private void Register(object parameter)
        {
            
        }
    }
}
