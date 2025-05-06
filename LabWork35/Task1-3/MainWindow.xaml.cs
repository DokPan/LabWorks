 public partial class MainWindow : Window
 {
     public MainWindow()
     {
         InitializeComponent();
     }

     private void OpenButton_Click(object sender, RoutedEventArgs e)
     {
         OpenFileDialog dialog = new();
         dialog.Filter = "допустимые расширения: |*.txt; *.cs; *.html; *.css; *.js; *.sql";

         if (dialog.ShowDialog() != true)
             return;

         InputTextBox.Text = File.ReadAllText(dialog.FileName);
         Title = dialog.FileName;
     }

     private void SaveButton_Click(object sender, RoutedEventArgs e)
     {
         SaveFileDialog dialog = new();
         dialog.Filter = "допустимые расширения: |*.txt; *.cs; *.html; *.css; *.js; *.sql";
         Title = "Сохранить файл";
         dialog.DefaultExt = "txt";

         if (dialog.ShowDialog() != true)
             return;

         string fileName = dialog.FileName;
         File.WriteAllText(fileName, InputTextBox.Text);
         MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
     }

     private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
     {
         if (MessageBox.Show("Вы хотите закрыть приложение?", "Подтверждение", 
             MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
             e.Cancel = true;
     }
 }
