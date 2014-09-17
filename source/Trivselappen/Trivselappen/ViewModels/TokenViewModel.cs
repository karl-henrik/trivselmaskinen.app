using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Trivselappen.ViewModels
{
    public class TokenViewModel : INotifyPropertyChanged
    {
        public TokenViewModel()
        {
            Token = "Kanin!!!";
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

        public ICommand Register
        {
            get
            {
                return new Command(() => {
                    var text = Token;
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
