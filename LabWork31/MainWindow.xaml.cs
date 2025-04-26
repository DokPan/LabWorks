 public partial class MainWindow : Window
 {
     public MainWindow()
     {
         InitializeComponent();
         BirthdayDatePicker.DisplayDateEnd = DateTime.Today;
         MeetingDatePicker.DisplayDateStart = DateTime.Today;
     }

     private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
     {
         ValidateInputs();
     }

     private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
     {
         int lenght = PasswordBox.Password.Length;
         PasswordInfoTextBlock.Text = lenght.ToString();
         ValidateInputs();
     }

     private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
     {
         ValidateInputs();
     }

     private void AboutTextBox_TextChanged(object sender, TextChangedEventArgs e)
     {
         int remaining = AboutTextBox.MaxLength - AboutTextBox.Text.Length;
         AboutInfoTextBlock.Text = remaining.ToString();
         ValidateInputs();
     }
     private void BirthdayDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
     {
         if (BirthdayDatePicker.SelectedDate.HasValue)
         {
             var birthDate = BirthdayDatePicker.SelectedDate.Value;
             var today = DateTime.Today;
             int age = today.Year - birthDate.Year;
             if (birthDate > today.AddYears(-age)) 
                 age--;
             AgeTextBlock.Text = $"Возраст: {age}";
         }
     }

     private void ExperienceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
     {
         int value = (int)ExperienceSlider.Value;

         int mod = value % 10;

         //string ending = mod == 1 && value != 11 ? "год" : 
         //    (mod >= 2 && mod <= 4 && (value < 10 || value > 20)) ? "года" :
         //    "лет";

         string ending = (value >= 10 && value <= 20 || mod == 0 || mod > 4) ? "лет" : mod == 1 ? "год" : "года";
         ExperienceTextBlock.Text = $"Стаж: {value} {ending}";
     }

     private void MeetingButtonAdd_Click(object sender, RoutedEventArgs e)
     {
         if (MeetingDatePicker.SelectedDate.HasValue)
         {
             DateTime selectedDate = MeetingDatePicker.SelectedDate.Value;
             if (!MeetingsCalendar.SelectedDates.Contains(selectedDate))
                 MeetingsCalendar.SelectedDates.Add(selectedDate);
         }
     }

     private void ValidateInputs()
     {
         Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

         EmailTextBox.BorderBrush = emailRegex.IsMatch(EmailTextBox.Text) ? Brushes.Gray : Brushes.Red;
         EmailErrorTextBlock.Text = emailRegex.IsMatch(EmailTextBox.Text) ? "" : "Проверьте корректность ввода Email.";

         PasswordBox.BorderBrush = (PasswordBox.Password == ConfirmPasswordBox.Password) ? Brushes.Gray : Brushes.Red;
         ConfirmPasswordBox.BorderBrush = (PasswordBox.Password == ConfirmPasswordBox.Password) ? Brushes.Gray : Brushes.Red;
         PasswordErrorTextBlock.Text = (PasswordBox.Password == ConfirmPasswordBox.Password) ? "" : "Проверьте совпадение паролей.";
     }
 }
