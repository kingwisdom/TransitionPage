using System;
using TransitionPage.Controls;
using TransitionPage.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransitionPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TransitionNavigationPage(new MainView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
