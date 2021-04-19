using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using LessonFourLab.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LessonFourLab
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();

            this.BindingContext = this;

            MyList = new ObservableCollection<Classmates>();

            for (int i = 1; i < 10; i++)
            {
                MyList.Add(new Classmates() { Id = i, Name = "Student ", Address = "Address" + i.ToString() });
            }

            MyList.Add(new Classmates()
            {
   
                Id = MyList.Count + 1,
                Name = "Christopher ",
                Address = "219 King St, Pewaukee WI"
            });
            MyList.Add(new Classmates()
            {

                Id = MyList.Count + 1,
                Name = "Jim ",
                Address = "301 Route BLVD, Pewaukee WI"
            });
            MyList.Add(new Classmates()
            {

                Id = MyList.Count + 1,
                Name = "Dan ",
                Address = "903 Main St, Pewaukee WI"
            });


            ClassmatesList.ItemsSource = myList;
        }

        private async void OnBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LessonFourLab.MainPage());
        }


        private ObservableCollection<Classmates> myList;

        public ObservableCollection<Classmates> MyList
        {
            get { return myList; }
            set { myList = value; }
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            var classmatesLength = myList.Count +1;
            MyList.Add(new Classmates() { Id = classmatesLength++, Name = "Student", Address = "123 Mill st.", Image = "usa.png" });
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            MyList.Remove(MyList.LastOrDefault());
        }

        private void MenuItem_Delete(object sender, EventArgs e)
        {
            var mi = sender as MenuItem;
            MyList.Remove((Classmates)mi.CommandParameter);
        }




    }
}
