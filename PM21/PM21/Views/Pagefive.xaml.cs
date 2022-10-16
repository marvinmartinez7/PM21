using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM21.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagefive : ContentPage
    {
        public Pagefive()
        {
            InitializeComponent();
        }

        public Pagefive(String Milti)
        {
            InitializeComponent();
            lbresultado1.Text = Milti;
        }
    }
}