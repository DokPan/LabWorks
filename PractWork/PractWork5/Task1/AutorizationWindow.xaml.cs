public partial class AutorizationWindow : Window
{
    public AutorizationWindow()
    {
        InitializeComponent();
    }

    private void AutorizationButton_Click(object sender, RoutedEventArgs e)
    {
        if (LoginTextBox.Text == Properties.Settings.Default.login && 
            PasswordTextBox.Text == Properties.Settings.Default.password)
        {
            MessageBox.Show("Успешная авторизация");
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }
        else
            MessageBox.Show("Неверный логин или пароль");
    }
}

//XAML
/*<Window Title="LoginWindow" Height="450" Width="800">
    <StackPanel>
        <TextBlock Text="Login"/>
        <TextBox x:Name="LoginTextBox"/>
        <TextBlock Text="Password"/>
        <TextBox x:Name="PasswordTextBox"/>
        <Button Content="Войти" x:Name="AutorizationButton" Click="AutorizationButton_Click"/>
    </StackPanel>
</Window> */
