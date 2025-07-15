using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using ContactList.Models;

namespace ContactList.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        // This attribute creates the public "Contacts" property for you.
        [ObservableProperty]
        private ObservableCollection<Models.Contact> _contacts;

        public ContactsViewModel()
        {
            Contacts = new ObservableCollection<Models.Contact>();
        }

        // The extra manual property has been removed.
    }
}