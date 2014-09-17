using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trivselappen.Views;
using Xamarin.Forms;

namespace Trivselappen
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new MainView());
        }
    }
}
