using System;
using System.Collections.Generic;
using NavigationTypes.Models;
using Xamarin.Forms;

namespace NavigationTypes
{
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPage(Contact contact)
        {
            // check if the contact is null
            if (contact == null)
            {
                throw new ArgumentException();
            }

            BindingContext = contact;

            InitializeComponent();
        }
    }
}
