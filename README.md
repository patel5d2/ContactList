# ContactList

This is a cross-platform contact management application built using .NET MAUI. It supports multiple platforms including Android, iOS, and macOS.

## Features

- **Add Contacts**: Add new contacts with details such as name, email, phone number, and description.
- **View Contacts**: Browse through the list of contacts with easy navigation.
- **Edit Contacts**: Update details of existing contacts.

## Project Structure

- **ContactList.csproj**: The main project file containing build and framework information.
- **Models/Contact.cs**: Defines the Contact model, utilizing `ObservableObject` for MVVM data binding.
- **Views**: Contains XAML files for the UI, including pages for viewing, adding, and editing contacts.
  - `ContactsPage.xaml`: Displays a list of contacts.
  - `AddContactPage.xaml`: Page for adding new contacts.
  - `ContactDetailsPage.xaml`: Details view for each contact.

## Dependencies

- **Microsoft.Maui.Controls**: For building native user interfaces.
- **CommunityToolkit.Mvvm**: MVVM Toolkit for simplified state management and data binding.

## Setting up the Development Environment

1. **Install .NET 9 SDK**: Ensure you have the .NET 9 SDK installed on your machine.
2. **Clone the Repository**: Run `git clone https://github.com/patel5d2/ContactList.git` to clone the repository.
3. **Open the Solution**: Open the `ContactList.sln` solution file in Visual Studio (Ensure you have Visual Studio 2022 or later).
4. **Build and Run**: Select the target platform (e.g., Android, iOS, macOS) and run the application.

## Contributing

Contributions are welcome! Please open issues or submit pull requests for any features or bug fixes.

## License

This project is licensed under the MIT License.
