using CommunityToolkit.Mvvm.ComponentModel;

namespace ContactList.Models
{
    // This class now correctly implements INotifyPropertyChanged through ObservableObject
    public partial class Contact : ObservableObject
    {
        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _email = string.Empty;

        [ObservableProperty]
        private string _phoneNumber = string.Empty;

        [ObservableProperty]
        private string _description = string.Empty;
    }
}