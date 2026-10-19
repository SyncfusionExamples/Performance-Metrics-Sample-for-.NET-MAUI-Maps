using System.Diagnostics;
using Syncfusion.Maui.Maps;

namespace ShapeLayerPerformanceSample;

public partial class ZoomPage : ContentPage
{
    private Stopwatch stopwatch = new();

    public ZoomPage()
    {
        InitializeComponent();
    }

    private async void RunZoomButton_Clicked(object? sender, EventArgs e)
    {
        stopwatch.Start();

        zoomPanBehavior.EnableZooming = true;
        zoomPanBehavior.ZoomLevel = 5;

        stopwatch.Stop();
        ZoomTimeLabel.Text = $"Zoom Render Time: " + $"{stopwatch.Elapsed.TotalMilliseconds:F0} ms";
    }
}

