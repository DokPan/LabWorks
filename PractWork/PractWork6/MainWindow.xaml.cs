public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        GetTotalPrice();
    }

    private void RadioButton_Checked(object sender, RoutedEventArgs e)
    {
        if (sender is RadioButton radioButton)
            Title = radioButton.Content.ToString();
    }
    public void GetTotalPrice()
    {
        if (int.TryParse(PriceTextBox.Text, out int price))
            TotalPriceTextBlock.Text = $"{price * QuantityControl.ValueText} руб.";
    }

    private void PriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        GetTotalPrice();
    } 
}
