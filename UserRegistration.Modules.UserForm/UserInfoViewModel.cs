using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UserRegistration.Modules.UserForm.Model;

namespace UserRegistration.Modules.UserForm
{
    public class UserInfoViewModel : BindableBase
    {        
        

        private User _user;
        private ObservableCollection<User> _users;
        //private ICommand _submitCommand;
        private ICommand _submitCommand;

        public UserInfoViewModel()
        {
            User = new User();
            Users = new ObservableCollection<User>();
            Users.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Users_CollectionChanged);
        }

        private void Users_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            RaisePropertyChanged("Users");
        }

        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                RaisePropertyChanged("User");
            }
        }

        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                RaisePropertyChanged("Users");
            }
        }

        public ICommand SubmitCommand
        {
            get
            {
                if(_submitCommand==null)
                {
                    _submitCommand = new RelayCommand(param => this.Submit(),param=> this.isExistAll());
                }
                return _submitCommand;
            }
        }

        public bool isExistAll()
        {
            return !string.IsNullOrEmpty(User.Age) && !string.IsNullOrEmpty(User.City) && !string.IsNullOrEmpty(User.Name);
        }

        private void Submit()
        {
            Users.Add(User);
            User = new User();
        }

    }
}
