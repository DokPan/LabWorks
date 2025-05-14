public partial class SettingsWindow : Window
{
    public SettingsWindow()
    {
        InitializeComponent();
        string[] lines = File.ReadAllLines("userData.txt");
        LoginTextBox.Text = lines[0];
        PasswordTextBox.Text = lines[1];
        EmailTextBox.Text = lines[2];
    }

    private void ButtonSave_Click(object sender, RoutedEventArgs e)
    {
        var passwordHash = GetHash(PasswordTextBox.Text);
        string[] lines =
         {
            LoginTextBox.Text,
            passwordHash,
            EmailTextBox.Text,
        };
        File.WriteAllLines("userData.txt", lines);
        MessageBox.Show(passwordHash);
    }

    private string GetHash(string hash)
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(hash);
        byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);
        hash = Convert.ToHexString(hashedBytes);
        return hash;
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
