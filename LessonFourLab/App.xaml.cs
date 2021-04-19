using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LessonFourLab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            var navPage = new NavigationPage(MainPage);
            this.MainPage = navPage;

            MainPage = new NavigationPage(new LessonFourLab.MainPage());

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
