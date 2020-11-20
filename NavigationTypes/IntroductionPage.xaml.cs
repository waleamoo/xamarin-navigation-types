﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationTypes
{
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
