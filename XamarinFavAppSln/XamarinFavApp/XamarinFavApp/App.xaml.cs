using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFavApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navePage = new NavigationPage(new FavoriteTabbedPage());
            navePage.BackgroundColor = Color.Violet;
            MainPage = navePage;
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
