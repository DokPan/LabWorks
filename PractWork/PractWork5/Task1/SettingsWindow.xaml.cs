public partial class SettingsWindow : Window
{
    public SettingsWindow()
    {
        InitializeComponent();
        LoginTextBox.Text = Properties.Settings.Default.login;
        PasswordTextBox.Text = Properties.Settings.Default.password;
        EmailTextBox.Text = Properties.Settings.Default.email;
    }

    private void ButtonSave_Click(object sender, RoutedEventArgs e)
    {
        Properties.Settings.Default.login = LoginTextBox.Text;
        Properties.Settings.Default.password = PasswordTextBox.Text;
        Properties.Settings.Default.email = EmailTextBox.Text;
        Properties.Settings.Default.Save();
        MessageBox.Show("Настройки сохранены");
    }
}

// XAML
/*<Windown Title="SettingsWindow" Height="450" Width="800">
    <StackPanel>
        <TextBlock Text="Логин:"/>
        <TextBox x:Name="LoginTextBox"/>
        <TextBlock Text="Пароль:"/>
        <TextBox x:Name="PasswordTextBox"/>
        <TextBlock Text="Почта:"/>
        <TextBox x:Name="EmailTextBox"/>
        <Button Content="Сохранить" x:Name="ButtonSave" Click="ButtonSave_Click"/>
    </StackPanel>
</Window>*/
