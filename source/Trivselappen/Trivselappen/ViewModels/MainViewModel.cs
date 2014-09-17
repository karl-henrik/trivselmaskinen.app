using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivselappen.Views;
using Xamarin.Forms;

namespace Trivselappen.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel(INavigation navigation)
        {
            navigation.PushAsync(new TokenView());
        }


    }
}
