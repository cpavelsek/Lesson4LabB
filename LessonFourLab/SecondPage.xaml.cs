using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LessonFourLab
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void OnBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LessonFourLab.MainPage());
        }
    }
}
