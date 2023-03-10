using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace wpftest.ViewModels
{
    public class SignUpViewModel : ObservableRecipient
    {
        #region Private Methods
        private void OnRegister()
        {

        }
        #endregion Private Methods
        #region Public Methods
        public ICommand RegsiterUserCommand { get; set; }
        #endregion Public Methods
        public SignUpViewModel()
        {
            this.RegsiterUserCommand = new RelayCommand(OnRegister);
        }
    }
}
