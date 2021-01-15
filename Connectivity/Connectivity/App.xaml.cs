using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;

namespace Connectivity
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            CrossConnectivity.Current.ConnectivityChanged += connectivityEvent;
        }

        private void connectivityEvent(object sender, ConnectivityChangedEventArgs e)
        {
            //when app detect internet
            if(e.IsConnected)
            {
                MainPage = new MainPage();
            }
            //when app detect no internet
            if(!e.IsConnected)
            {
                MainPage = new MainPage();
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
