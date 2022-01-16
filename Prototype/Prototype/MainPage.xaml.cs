using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void EP1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EquationPage1());
        }
        private async void EP2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EquationPage2());
        }

        private async void EP3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EquationPage3());
        }

        private async void EP4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EquationPage4());
        }

        private async void Thesaurus(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Thesaurus());
        }
        
        private async void Settings(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Settings());
        }
    }
}
