using System;
using System.Collections.Generic;
using NavigationTypes.Models;
using Xamarin.Forms;

namespace NavigationTypes
{
    public partial class ContactMasterPage : MasterDetailPage
    {
        public ContactMasterPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Wale", Status = "Hello!" },
                new Contact { Name = "Ruka", Status = "Hi, my name is Ruka" },
                new Contact { Name = "Crazy Mosh", Status = "Hi, let's talk!" }
            };
        }

        void listView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactDetailPage(contact));
            IsPresented = false; // Master goes away, detail comes into view 
        }
    }
}
