public partial class AutorizationWindow : Window
 {
     public AutorizationWindow()
     {
         InitializeComponent();
     }

     private void AutorizationButton_Click(object sender, RoutedEventArgs e)
     {
         string[] lines = File.ReadAllLines("userData.txt");

         if (LoginTextBox.Text == lines[0] && GetHash(PasswordTextBox.Text) == lines[1])
         {
             MessageBox.Show("Успешная авторизация");
             SettingsWindow settingsWindow = new();
             settingsWindow.ShowDialog();
         }
         else
         {
             MessageBox.Show("Неверный логин или пароль"); 
             MessageBox.Show($"Хэш введённого пароля: {GetHash(PasswordTextBox.Text)}\nХэш хранящегося пароля: {lines[1]}");
         }
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
/*<Window Title="LoginWindow" Height="450" Width="800">
    <StackPanel>
        <TextBlock Text="Login"/>
        <TextBox x:Name="LoginTextBox"/>
        <TextBlock Text="Password"/>
        <TextBox x:Name="PasswordTextBox"/>
        <Button Content="Войти" x:Name="AutorizationButton" Click="AutorizationButton_Click"/>
    </StackPanel>
</Window>*/
