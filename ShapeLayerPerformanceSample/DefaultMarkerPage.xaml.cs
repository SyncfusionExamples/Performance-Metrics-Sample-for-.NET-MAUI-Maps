using System.Diagnostics;
using Syncfusion.Maui.Maps;

namespace ShapeLayerPerformanceSample;

public partial class DefaultMarkerPage : ContentPage
{

    private readonly Stopwatch defaultMarkerStopwatch = new();

    public DefaultMarkerPage()
    {
        InitializeComponent();
    }

    private void LoadDefaultMarkersButton_Clicked(object? sender, EventArgs e)
    {

        defaultMarkerStopwatch.Restart();
        MapMarkerCollection markers = CreateDefaultMarkers();
        shapeLayer.Markers = markers;
        defaultMarkerStopwatch.Stop();
        DefaultMarkerCountLabel.Text = $"Default Marker Count: {markers.Count}";
        DefaultMarkerTimeLabel.Text = $"Default Marker Render Time: " +  $"{defaultMarkerStopwatch.Elapsed.TotalMilliseconds:F0} ms";
    }

    private static MapMarkerCollection CreateDefaultMarkers()
    {
        MapMarkerCollection markers = new();

        foreach (CountryLocation country in CountryLocationData.Countries)
        {
            markers.Add(
                new MapMarker
                {
                    Latitude = country.Latitude,
                    Longitude = country.Longitude
                });
        }

        return markers;
    }
}