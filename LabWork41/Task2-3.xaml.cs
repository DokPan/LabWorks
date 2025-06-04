public partial class Task23 : Window
{
    public Task23()
    {
        InitializeComponent();
        Loaded += Window_Loaded;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        DoubleAnimation fontAnimation = new()
        {
            From = 16,
            To = 32,
            AutoReverse = true,
            RepeatBehavior = new RepeatBehavior(2),
            Duration = new Duration(TimeSpan.FromSeconds(0.5))
        };
        AnimatedTextButton.BeginAnimation(FontSizeProperty, fontAnimation);

        var sb = new Storyboard();

        DoubleAnimation widthAnim = new DoubleAnimation(100, 200, TimeSpan.FromSeconds(0.5))
        {
            AutoReverse = true,
            RepeatBehavior = new RepeatBehavior(2)
        };
        DoubleAnimation heightAnim = new DoubleAnimation(40, 80, TimeSpan.FromSeconds(0.5))
        {
            AutoReverse = true,
            RepeatBehavior = new RepeatBehavior(2)
        };
        DoubleAnimation fontSizeAnim = new DoubleAnimation(16, 32, TimeSpan.FromSeconds(0.5))
        {
            AutoReverse = true,
            RepeatBehavior = new RepeatBehavior(2)
        };

        Storyboard.SetTarget(widthAnim, AnimatedTextButton);
        Storyboard.SetTargetProperty(widthAnim, new PropertyPath(Button.WidthProperty));

        Storyboard.SetTarget(heightAnim, AnimatedTextButton);
        Storyboard.SetTargetProperty(heightAnim, new PropertyPath(Button.HeightProperty));

        Storyboard.SetTarget(fontSizeAnim, AnimatedTextButton);
        Storyboard.SetTargetProperty(fontSizeAnim, new PropertyPath(Button.FontSizeProperty));

        sb.Children.Add(widthAnim);
        sb.Children.Add(heightAnim);
        sb.Children.Add(fontSizeAnim);
        sb.Begin();
    }
}

# XAML
/*<Grid>
    <Button x:Name="AnimatedTextButton" Content="Текст" FontSize="16" Width="100" Height="40" VerticalAlignment="Center" HorizontalAlignment="Center"/>
</Grid>*/
