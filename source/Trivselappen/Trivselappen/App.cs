using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trivselappen.ServiceAgents;
using Trivselappen.ServiceAgents.Mocks;
using Trivselappen.ViewModels;
using Trivselappen.Views;
using Xamarin.Forms;

namespace Trivselappen
{
    public class App
    {
        public static IContainer Container { get; set; }

        public static Page GetMainPage()
        {
            return new NavigationPage(Container.Resolve<MainView>());
        }

        public static void SetupIoC(ContainerBuilder builder)
        {
            builder.RegisterType<MainView>();
            builder.RegisterType<QuestionView>();
            builder.RegisterType<TokenView>();

            builder.RegisterType<MainViewModel>();
            builder.RegisterType<TokenViewModel>();
            builder.RegisterType<QuestionViewModel>();

            builder.RegisterType<MockQuestionServiceAgent>().As<IQuestionServiceAgent>();
            builder.RegisterType<MockDeviceServiceAgent>().As<IDeviceServiceAgent>();
        }
    }
}
