using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationTypes
{
    public partial class ContactMethodsPage : ContentPage
    {
        // makes the listview a public property - and accessible outside this page 
        public ListView ContactMethods { get { return listView; } }

        public ContactMethodsPage()
        {
            InitializeComponent();

            // set the item source
            listView.ItemsSource = new List<string>
            {
                "None", "Email", "SMS"
            };
        }
    }
}
