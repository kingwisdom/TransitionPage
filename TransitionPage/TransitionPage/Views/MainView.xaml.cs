using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitionPage.Enums;
using TransitionPage.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransitionPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<MainViewModel, TransitionType>(this, AppSettings.TransitionMessage, (sender, arg) =>
            {
                var transitionType = (TransitionType)arg;
                var tranNavPage = Parent as Controls.TransitionNavigationPage;
                if (tranNavPage != null)
                {
                    tranNavPage.TransitionType = transitionType;
                    Navigation.PushAsync(new DetailView());
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MainViewModel, TransitionType>(this, AppSettings.TransitionMessage);
        }
    }
}