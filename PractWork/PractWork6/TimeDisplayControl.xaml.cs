public partial class TimeDisplayControl : UserControl
{
    private DispatcherTimer timer = new(DispatcherPriority.Render);

    public TimeDisplayControl()
    {
        InitializeComponent();
        DataContext = this;
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        TimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
    }
}
