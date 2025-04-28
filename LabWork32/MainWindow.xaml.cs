public partial class MainWindow : Window
{
    public List<Product> Products { get; set; } = new List<Product>();

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;

        LoadProducts();
        LoadCategories();
    }

    private void LoadProducts()
    {
        Products.Add(new Product { Id = 1, Name = "Товар 1", Category = "Электроника", Price = 100 });
        Products.Add(new Product { Id = 2, Name = "Товар 2", Category = "Одежда", Price = 50 });
        Products.Add(new Product { Id = 3, Name = "Товар 3", Category = "Обувь", Price = 70 });
        Products.Add(new Product { Id = 4, Name = "Товар 4", Category = "Канцтовары", Price = 20 });
        Products.Add(new Product { Id = 5, Name = "Товар 5", Category = "Бытовая техника", Price = 200 });

        ProductListView.ItemsSource = Products;
    }

    private void LoadCategories()
    {
        var categories = new List<string> { "Электроника", "Одежда", "Обувь", "Канцтовары", "Бытовая техника", "Игрушки", "Мебель", "Книги", "Спорт", "Красота", "Продукты", "Музыка", "Игры", "Фигурки" };
        CategoryListBox.ItemsSource = categories;
    }



    private void ApplyAvailability_Click(object sender, RoutedEventArgs e)
    {
        string sortOption = "";
        if (SortComboBox.SelectedItem is ComboBoxItem selectedSortItem)
            sortOption = selectedSortItem.Content.ToString();


        string category = "";
        if (CategoryListBox.SelectedItem != null)
            category = CategoryListBox.SelectedItem.ToString();

        List<string> selectedAvailability = new List<string>();
        foreach (var item in AvailabilityListBox.Items)
            if (item is CheckBox checkBox && checkBox.IsChecked == true)
                selectedAvailability.Add(checkBox.Content.ToString());

        string result = $"Сортировка: {sortOption}\n" +
                        $"Категория: {category}\n" +
                        $"Наличие: {string.Join(", ", selectedAvailability)}";

        ResultTextBlock.Text = result;

    }

    private void ViewToggleButton_Click(object sender, RoutedEventArgs e)
    {
        if (ViewToggleButton.IsChecked == true)
        {
            ProductListView.ItemsPanel = (ItemsPanelTemplate)FindResource("TilePanelTemplate");
            ProductListView.ItemTemplate = (DataTemplate)FindResource("TileItemTemplate");
        }
        else
        {
            ProductListView.ItemsPanel = (ItemsPanelTemplate)FindResource("ListPanelTemplate");
            ProductListView.ItemTemplate = (DataTemplate)FindResource("ListItemTemplate");
        }
    }

    private void BuyButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button btn && btn.Tag is Product product)
            CartListBox.Items.Add(product);
    }

    private void DeleteFromCart_Click(object sender, RoutedEventArgs e)
    {
        var selected = CartListBox.SelectedItems.Cast<Product>().ToList();
        foreach (var item in selected)
            CartListBox.Items.Remove(item);
    }
}
