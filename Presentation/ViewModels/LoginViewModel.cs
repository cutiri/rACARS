using rACARS.Model.Configs;
using rACARS.Model.PhpVmsAPI;
using rACARS.Presentation.Extensions;
using rACARS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace rACARS.Presentation.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        //private SimpleMessage message;
        private string message;
        private PhpVmsTranslator phpVmsTranslator;
        public AsyncRelayCommand LoginCommand { get; }
        
        public delegate void DConnectedSuccesfully();
        public event DConnectedSuccesfully OnConnectedSuccesfully;

        #region Properties
        public User User{ get; private set; }
        public string ApiKey
        {
            get
            {
                return ConfigModel.PhpVmsApiKey;
            }
            set
            {
                ConfigModel.PhpVmsApiKey = value;
                NotifyPropertyChanged();
            }
        }
        public string Message { get { return message; } private set { message = value; NotifyPropertyChanged(); } }
        #endregion


        #region Constructors
        public LoginViewModel()
        {
            phpVmsTranslator = new PhpVmsTranslator();
            LoginCommand = new AsyncRelayCommand(Connect);
            Message = "";
        } 
        #endregion


        public async Task<User> Connect()
        {
            try
            {
                Message = "Intentando conectar con el servidor.";
                var temp = await phpVmsTranslator.Connect();
                if (temp == null)
                {
                    throw new Exception("Hubo un error en la respuesta del servidor.");
                }
                else
                {
                    User = temp;
                    OnConnectedSuccesfully();
                    return temp;
                }
            }
            catch(Exception e)
            {
                Message = e.Message;// new SimpleMessage() { Message = e.Message, Type = MessageBoxImage.Error};
            }
            return null;
        }
    }
}
