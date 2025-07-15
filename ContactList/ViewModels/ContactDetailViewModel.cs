using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactList.Models;
using System.Threading.Tasks;

namespace ContactList.ViewModels
{
    [QueryProperty(nameof(SelectedContact), "SelectedContact")]
    public partial class ContactDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotEditing))]
        private bool _isEditing;

        // Corrected to specify Models.Contact to resolve ambiguity
        [ObservableProperty]
        private Models.Contact? _selectedContact;

        public bool IsNotEditing => !IsEditing;

        [RelayCommand]
        private void ToggleEdit()
        {
            IsEditing = !IsEditing;
        }

        [RelayCommand]
        private async Task SaveChanges()
        {
            IsEditing = false;
            await Shell.Current.GoToAsync("..");
        }
    }
}