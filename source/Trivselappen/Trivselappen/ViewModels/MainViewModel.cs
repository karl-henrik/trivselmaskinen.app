using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Trivselappen.Views;
using Xamarin.Forms;
using Autofac;

namespace Trivselappen.ViewModels
{
    public class MainViewModel
    {
        private INavigation _navigation;
        public MainViewModel(INavigation navigation)

        {

            _navigation = navigation;        
            
        }

       

        public ICommand Token
        {
            get
            {
                return new Command( () =>
                {
                     _navigation.PushAsync(App.Container.Resolve<TokenView>());

                });
            }
        }

        public ICommand Question
        {
            get
            {
                return new Command(() =>
                {
                    _navigation.PushAsync(new QuestionView());

                });
            }
        }

    }
}