using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM21
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSuma_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtn1.Text);
            int n2 = Convert.ToInt32(txtn2.Text);
            int suma = n1 + n2;
            
            var emple = new Models.Ari
            {
                Sum =suma,
           

            };
            var pagetwo = new Views.PageTwo();
            pagetwo.BindingContext = emple;
            await Navigation.PushAsync(pagetwo);


        }

        private async void btnResta_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtn1.Text);
            int n2 = Convert.ToInt32(txtn2.Text);
            int resta = n1 - n2;
            var emple = new Models.Ari
            {
                Resta = resta,


            };
            var pagethree = new Views.Pagethree();
            pagethree.BindingContext = emple;
            await Navigation.PushAsync(pagethree);

        }

        private async void btnDivi_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtn1.Text);
            int n2 = Convert.ToInt32(txtn2.Text);
            int div = n1 / n2;
            var emple = new Models.Ari
            {
                Div = div,


            };
            var pagefour = new Views.Pagefour();
            pagefour.BindingContext = emple;
            await Navigation.PushAsync(pagefour);

        }

        private async void btnMult_Clicked(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtn1.Text);
            int n2 = Convert.ToInt32(txtn2.Text);
            int Mult = n1 * n2;
            var emple = new Models.Ari
            {
               Milti = Mult,


            };
            var pagefive = new Views.Pagefive();
            pagefive.BindingContext = emple;
            await Navigation.PushAsync(pagefive);


        }
    }
}
