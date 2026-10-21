using Syncfusion.Maui.Maps;
using System.Diagnostics;

namespace ShapeLayerPerformanceSample;

public partial class CustomMarkerPage : ContentPage
{

    private readonly Stopwatch customMarkerStopwatch = new();

    public CustomMarkerPage()
    {
        InitializeComponent();
    }

    private void LoadCustomMarkersButton_Clicked(object? sender, EventArgs e)
    {

        customMarkerStopwatch.Start();
        MapMarkerCollection markers = CreateCustomMarkers();
        shapeLayer.Markers = markers;
        customMarkerStopwatch.Stop();
        CustomMarkerCountLabel.Text = $"Custom Marker Count: {markers.Count}";
        CustomMarkerTimeLabel.Text = $"Custom Marker Load Time: " +  $"{customMarkerStopwatch.Elapsed.TotalMilliseconds:F0} ms";
    }

    private static MapMarkerCollection CreateCustomMarkers()
    {
        MapMarkerCollection markers = new();

        foreach (CountryLocation country in CountryLocationData.Countries)
        {
            markers.Add(
                new MapMarker
                {
                    Latitude = country.Latitude,
                    Longitude = country.Longitude,
                    HorizontalAlignment = MapAlignment.Center,
                    VerticalAlignment = MapAlignment.Start
                });
        }

        return markers;
    }
}