﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivselappen.ViewModels;
using System.Windows.Input;
using Xamarin.Forms;

namespace Trivselappen.Views
{
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = new MainViewModel(this.Navigation);
        }
    }
}
