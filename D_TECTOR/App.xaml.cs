using D_TECTOR.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace D_TECTOR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
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
