public partial class AutorizationWindow : Window
{
    public AutorizationWindow()
    {
        InitializeComponent();
    }

    private void AutorizationButton_Click(object sender, RoutedEventArgs e)
    {
        if (LoginTextBox.Text != ConfigurationManager.AppSettings["login"] ||
            PasswordTextBox.Text != ConfigurationManager.AppSettings["password"])
        {
            MessageBox.Show("Неверный логин или пароль");
        }
        else
        {
            MessageBox.Show("Успешная авторизация");
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
    }
}

// XAML
/*<Window x:Class="PractWork5."
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:PractWork5"
        mc:Ignorable="d"
        Title="LoginWindow" Height="450" Width="800">
    <StackPanel>
        <TextBlock Text="Login"/>
        <TextBox x:Name="LoginTextBox"/>
        <TextBlock Text="Password"/>
        <TextBox x:Name="PasswordTextBox"/>
        <Button Content="Войти" x:Name="AutorizationButton" Click="AutorizationButton_Click"/>
    </StackPanel>
</Window>*/
