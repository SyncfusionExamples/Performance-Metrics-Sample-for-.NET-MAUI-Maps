using Syncfusion.Maui.Maps;
using System.Diagnostics;

namespace ShapeLayerPerformanceSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            shapeLayer.ShapesSource = MapSource.FromResource("ShapeLayerPerformanceSample.ShapeFiles.world.shp");
            stopwatch.Stop();
            InitialRenderTimeLabel.Text = $"Shape Layer Render Time: " + $"{stopwatch.Elapsed.TotalMilliseconds:F0} ms";
        }
    }
}