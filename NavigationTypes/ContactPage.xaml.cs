using System;
using System.Collections.Generic;
using NavigationTypes.Models;
using Xamarin.Forms;

namespace NavigationTypes
{
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Wale", Status = "Hello!" },
                new Contact { Name = "Ruka", Status = "Hi, my name is Ruka" },
                new Contact { Name = "Crazy Mosh", Status = "Hi, let's talk!" }
            };
        }

        async void listView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var contact = e.SelectedItem as Contact;
            // sending data to the next screen 3 Ways - the first two ways, the constructor of the code-behind file must have parameter of Contact 
            // Navigation.PushAsync(new ContactDetailPage(contact)); or Navigation.PushAsync(new ContactDetailPage(){ Contact = contact });
            // Navigation.PushAsync(new ContactDetailPage(){ BindingContext = contact });
            await Navigation.PushAsync(new ContactDetailPage(contact));

            // deselect an item from the list view 
            listView.SelectedItem = null;
        }
    }
}
