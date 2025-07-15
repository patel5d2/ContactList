using ContactList.ViewModels;

namespace ContactList.Views;

public partial class AddContactPage : ContentPage
{
    public AddContactPage(AddContactViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
 }
