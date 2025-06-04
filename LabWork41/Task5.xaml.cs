public partial class Task5 : Window
{
    public Task5()
    {
        InitializeComponent();
    }

    private void AnimateColor_Click(object sender, RoutedEventArgs e)
    {
        GradientStopCollection stops = ((RadialGradientBrush)ColorCircle.Fill).GradientStops;
        ColorAnimationUsingKeyFrames colorAnim = new ColorAnimationUsingKeyFrames
        {
            Duration = new Duration(TimeSpan.FromSeconds(5))
        };

        colorAnim.KeyFrames.Add(new LinearColorKeyFrame(Colors.Red, KeyTime.FromPercent(0)));
        colorAnim.KeyFrames.Add(new LinearColorKeyFrame(Colors.Orange, KeyTime.FromPercent(0.25)));
        colorAnim.KeyFrames.Add(new LinearColorKeyFrame(Colors.Yellow, KeyTime.FromPercent(0.5)));
        colorAnim.KeyFrames.Add(new LinearColorKeyFrame(Colors.Green, KeyTime.FromPercent(0.75)));
        colorAnim.KeyFrames.Add(new LinearColorKeyFrame(Colors.Blue, KeyTime.FromPercent(1)));

        stops[0].BeginAnimation(GradientStop.ColorProperty, colorAnim);
    }
}

#XAML
/*<Canvas>
    <Ellipse x:Name="ColorCircle" Width="100" Height="100" Canvas.Left="200" Canvas.Top="100">
        <Ellipse.Fill>
            <RadialGradientBrush x:Name="GradientBrush">
                <GradientStop Color="Red" Offset="0.0"/>
                <GradientStop Color="Yellow" Offset="1.0"/>
            </RadialGradientBrush>
        </Ellipse.Fill>
    </Ellipse>
    <Button Content="Анимировать" Canvas.Top="250" Canvas.Left="215" Click="AnimateColor_Click" HorizontalAlignment="Left" VerticalAlignment="Center"/>
</Canvas>*/
