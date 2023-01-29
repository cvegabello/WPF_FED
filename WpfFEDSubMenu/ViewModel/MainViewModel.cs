using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfFEDSubMenu.Model;
//using WPF_LoginForm.Models;
//using WPF_LoginForm.Repositories;

namespace WpfFEDSubMenu.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        //private UserAccountModel _currentUserAccount;
        //private IUserRepository userRepository;
        private ViewModelBase _currentChildView;
        private string _caption;
        private string _icon;

        //public UserAccountModel CurrentUserAccount
        //{
        //    get
        //    {
        //        return _currentUserAccount;
        //    }

        //    set
        //    {
        //        _currentUserAccount = value;
        //        OnPropertyChanged(nameof(CurrentUserAccount));
        //    }
        //}

        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }

        public String Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        // Switch Views
        public void SwitchViews(object parameter)
        {
            switch (parameter)
            {
                case "mnuHome":
                    CurrentChildView = new SwitchBoardViewModel();
                    Caption = "Main SwitchBoard";
                    Icon = "../Assets/img_home.png";
                    break;
                case "mnuMovies":
                    CurrentChildView = new CustomerViewModel();
                    Caption = "Movies";
                    Icon = "../Assets/img_movies.png";
                    break;

                case " View / Edit Fuel Element Database":
                    CurrentChildView = new SpecimenViewModel();
                    Caption = "FED - Fed Specimen Development";
                    Icon = "../Assets/img_map.png";
                    break;
                
                case "Exit FED":
                    Application.Current.Shutdown();
                    break;
                case "As Builts":
                    MessageBox.Show("Hola");
                    break;

                default:
                    CurrentChildView = new SwitchBoardViewModel();
                    break;
            }
        }

        //--> Commands

        private ICommand _menucommand;
        public ICommand MenuCommand
        {
            get
            {
                if (_menucommand == null)
                {
                    _menucommand = new ViewModelCommand(param => SwitchViews(param));
                }
                return _menucommand;
            }
        }

       
        private ICommand _specimenWindowCommand;
        public ICommand SpecimenWindowCommand
        {
            get
            {
                if (_specimenWindowCommand == null)
                {
                    _specimenWindowCommand = new ViewModelCommand(param => SwitchViews(param));
                }
                return _specimenWindowCommand;
            }
        }

        private ICommand _tabItemCommand;
        public ICommand TabItemCommand
        {
            get
            {
                if (_tabItemCommand == null)
                {
                    _tabItemCommand = new ViewModelCommand(param => SwitchViews(param));
                }
                return _tabItemCommand;
            }
        }



        //public ICommand ShowSwitchViewCommand { get; }
        //public ICommand ShowCustomerViewCommand { get; }

        public MainViewModel()
        {

            //userRepository = new UserRepository();
            //CurrentUserAccount = new UserAccountModel();

            //Initialize commands
            //ShowSwitchViewCommand = new ViewModelCommand(ExecuteShowSwitchViewCommand);
            //ShowCustomerViewCommand = new ViewModelCommand(ExecuteShowCustomerViewCommand);

            //Default view
            //ExecuteShowSwitchViewCommand(null);
            CurrentChildView = new SwitchBoardViewModel();
            Caption = "Main SwitchBoard";
            Icon = "../Assets/img_home.png";

            //LoadCurrentUserData();
        }

        //private void ExecuteShowSwitchViewCommand(object obj)
        //{
        //    CurrentChildView = new SwitchBoardViewModel();
        //    Caption = "Switch Board";
        //    //Icon = IconChar.UserGroup;
        //}

        //private void LoadCurrentUserData()
        //{
        //    var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
        //    if (user != null)
        //    {
        //        CurrentUserAccount.Username = user.Username;
        //        CurrentUserAccount.DisplayName = $"Welcome {user.Name} {user.LastName} ;)";
        //        CurrentUserAccount.ProfilePicture = null;
        //    }
        //    else
        //    {
        //        CurrentUserAccount.DisplayName = "Invalid user, not logged in";
        //        //Hide child views.
        //    }
        //}
    }
}
