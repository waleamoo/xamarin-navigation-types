using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationTypes
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionPage());
        }
    }
}
