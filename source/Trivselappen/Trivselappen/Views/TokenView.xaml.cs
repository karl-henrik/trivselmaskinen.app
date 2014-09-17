using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivselappen.ViewModels;

namespace Trivselappen.Views
{
    public partial class TokenView
    {
        public TokenView()
        {
            InitializeComponent();

            BindingContext = new TokenViewModel();
        }
    }
}
