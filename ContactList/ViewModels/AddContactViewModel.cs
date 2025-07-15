using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactList.Models;
using ContactList.Views;
using System.Threading.Tasks;

namespace ContactList.ViewModels
{
    public partial class AddContactViewModel : ObservableObject
    {
        private readonly ContactsViewModel _contactsViewModel;

        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _email = string.Empty;

        [ObservableProperty]
        private string _phoneNumber = string.Empty;

        [ObservableProperty]
        private string _description = string.Empty;

        public AddContactViewModel(ContactsViewModel contactsViewModel)
        {
            _contactsViewModel = contactsViewModel;
        }

        [RelayCommand]
        private async Task SaveContact()
        {
            // Corrected to specify Models.Contact to resolve ambiguity
            var newContact = new Models.Contact
            {
                Name = Name,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Description = Description
            };

            _contactsViewModel.Contacts.Add(newContact);

            Name = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Description = string.Empty;

            await Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
        }
    }
}