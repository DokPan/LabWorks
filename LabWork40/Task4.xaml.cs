public partial class Task4 : Window
{
    public Task4()
    {
        InitializeComponent();
    }

    private Random rand = new Random();

    private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
    {
        Point clickPos = e.GetPosition(MyCanvas);

        Ellipse circle = new Ellipse();
        double radius = rand.Next(10, 50);
        circle.Width = circle.Height = radius;
        circle.Fill = new SolidColorBrush(Color.FromRgb(
            (byte)rand.Next(256),
            (byte)rand.Next(256),
            (byte)rand.Next(256)
        ));

        Canvas.SetLeft(circle, clickPos.X);
        Canvas.SetTop(circle, clickPos.Y);

        MyCanvas.Children.Add(circle);

        string[] tags = { "enemy", "hero", "treasure" };
        string tag = tags[rand.Next(tags.Length)];
        circle.Tag = tag;

        circle.MouseDown += (s, args) =>
        {
            MessageBox.Show($"Тэг: {(s as Ellipse).Tag}");
            args.Handled = true;
        };
    }
}

# XAML
<Canvas x:Name="MyCanvas" Width="400" Height="400" Background="White" MouseDown="Canvas_MouseDown"/>
