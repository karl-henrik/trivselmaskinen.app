using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Trivselappen.ServiceAgents;
using Xamarin.Forms;
using Autofac;
using Trivselappen.Views;

namespace Trivselappen.ViewModels
{
    public class TokenViewModel : INotifyPropertyChanged
    {
        private IDeviceServiceAgent _deviceServiceAgent;
        public INavigation Navigation {get;set;}

        public TokenViewModel(IDeviceServiceAgent deviceServiceAgent)
        {
            _deviceServiceAgent = deviceServiceAgent;

            Token = "";
        }

        private string _token;
        public string Token { get{
            return _token;
        } 
            set{
                _token = value;
                RaisePropertyChanged("Token");
                }
        }
        string _greeting;
        public string Greeting
        {
            get { return _greeting; }
            set { _greeting = value; RaisePropertyChanged("Greeting"); }
        }

        public ICommand Register
        {
            get
            {
                return new Command(
                    async() =>
                    {
                        var text = Token;
                        Greeting = String.Format("Hello '{0}'", text);

                        var device = new Models.Device()
                        {
                            DeviceId = "",
                            MetaData = "",
                            Token = Token
                        };

                        var result = await _deviceServiceAgent.RegisterDeviceAsync(device);

                        if(result)
                        {
                            Navigation.PushAsync(App.Container.Resolve<QuestionView>());
                        }
                    });
            }

        }        
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
