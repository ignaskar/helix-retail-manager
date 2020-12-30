using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using HRMWPFUI.Helpers;
using HRMDesktopUI.Library.Api;
using HRMWPFUI.EventModels;

namespace HRMWPFUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _password;
        private string _userName;
        private string _errorMessage;
        private IAPIHelper _apiHelper;
        private IEventAggregator _events;


        public LoginViewModel(IAPIHelper apiHelper, IEventAggregator events)
        {
            _apiHelper = apiHelper;
            _events = events;
        }
        
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool IsErrorVisible
        {
            get
            {
                var output = ErrorMessage?.Length > 0;

                return output;
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }
        
        public bool CanLogIn
        {
            get
            {
                var output = UserName?.Length > 0 && Password?.Length > 0;

                return output;
            }
        }

        public async Task LogIn()
        {
            try
            {
                ErrorMessage = "";
                var result = await _apiHelper.Authenticate(UserName, Password);
                
                // Capture more info about the user
                await _apiHelper.GetLoggedInUserInfo(result.Access_Token);
                
                _events.PublishOnUIThread(new LogOnEvent());
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}