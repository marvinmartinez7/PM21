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
    public partial class Pagefour : ContentPage
    {
        public Pagefour()
        {
            InitializeComponent();
        }

        public Pagefour(String Div)
        {
            InitializeComponent();
            lbresultado1.Text = Div;
        }
    }
}