using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;
using wpftest.Views;


namespace wpftest.ViewModels
{
    public class MainWindowViewModel : ObservableRecipient
    {
        #region Public Properties
        private string _navigationSource;
        public string NavigationSource
        {
            get { return _navigationSource; }
            set { SetProperty(ref _navigationSource, value); }
        }
        #endregion Public Properties

        #region Private Methods
        private void Init()
        {
            NavigationSource = "Views/DashBoard.xaml";
            NavigateCommand = new RelayCommand<string>(OnNavigate);
        }

        private void OnNavigate(string pageUri)
        {
            NavigationSource = pageUri;
        }
        private void OnShowSignUp()
        {
            SignUp view = new SignUp();
            view.Owner = Application.Current.MainWindow;
            view.ShowDialog();
        }
        #endregion Private Methods

        public ICommand NavigateCommand { get; set; }
        public ICommand ShowSignUpCommand { get; set; }
        #region Constructor
        public MainWindowViewModel()
        {
            Init();
            this.ShowSignUpCommand = new RelayCommand(OnShowSignUp);
        }
        #endregion Constructor
    }
}
