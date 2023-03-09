using System.Windows;
using System.Windows.Controls;
using wpftest.ViewModels;

namespace wpftest.Views
{
    /// <summary>
    /// SignUp.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService(typeof(SignUpViewModel));
        }
    }
}
