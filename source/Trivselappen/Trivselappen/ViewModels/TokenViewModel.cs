﻿using System;
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
            Token = "Token!!!";
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
                    () =>
                    {
                        var text = Token;
                        Greeting = String.Format("Hello '{0}'", text);
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