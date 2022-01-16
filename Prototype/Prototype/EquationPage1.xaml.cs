using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EquationPage1 : ContentPage
    {
        public EquationPage1()
        {
            InitializeComponent();
            BindingContext = new OhmsLawViewModel();
        }

        void CalculateButton_Clicked(object sender, System.EventArgs e)
        {
            //anything i want to have done put here
            int V = Convert.ToInt32(Volts.Text);
            int I = Convert.ToInt32(Amps.Text);
            int R = Convert.ToInt32(Resistance.Text);
            V = I * R;
            Volts.Text = Convert.ToString(V);
        }

    } 
}