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
    public partial class Pagethree : ContentPage
    {
        public Pagethree()
        {
            InitializeComponent();
        }
        public Pagethree(String Resta)
        {
            InitializeComponent();
            lbresultado1.Text = Resta;
        }
    }
}