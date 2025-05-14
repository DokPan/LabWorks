public partial class SettingsWindow : Window
{
    public SettingsWindow()
    {
        InitializeComponent();
        LoginTextBox.Text = ConfigurationManager.AppSettings["login"];
        PasswordTextBox.Text = ConfigurationManager.AppSettings["password"];
        EmailTextBox.Text = ConfigurationManager.AppSettings["email"];
    }

    private void ButtonSave_Click(object sender, RoutedEventArgs e)
    {
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["login"].Value = LoginTextBox.Text;
        config.AppSettings.Settings["password"].Value = PasswordTextBox.Text;
        config.AppSettings.Settings["email"].Value = EmailTextBox.Text;
        config.Save(ConfigurationSaveMode.Modified);
        ConfigurationManager.RefreshSection("appSettings");
    }
}

// XAML
/*<Window Title="SettingsWindow" Height="450" Width="800">
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
