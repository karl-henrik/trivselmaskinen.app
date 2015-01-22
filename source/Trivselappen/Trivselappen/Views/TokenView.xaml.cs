using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivselappen.ViewModels;
using Xamarin.Forms;

namespace Trivselappen.Views
{
    public partial class TokenView : ContentPage
    {
        public TokenView(TokenViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = viewModel;
            viewModel.Navigation = Navigation;
        }
    }
}
