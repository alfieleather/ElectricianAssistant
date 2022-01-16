using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Prototype
{
    class trigger:Xamarin.Forms.TriggerAction<Xamarin.Forms.Button>
    {
        protected async override void Invoke(Button sender)
        {
            await sender.ScaleTo(0.5, 50, Easing.BounceIn);
            await sender.ScaleTo(1, 50, Easing.BounceOut);
        }
    }
}
