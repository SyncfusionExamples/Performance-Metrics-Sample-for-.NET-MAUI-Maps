using Syncfusion.Maui.Maps;
using System.Diagnostics;

namespace TileLayerPerformanceSample;

public partial class CustomMarkerPage : ContentPage
{
    private readonly Stopwatch customMarkerStopwatch = new();

    public CustomMarkerPage()
    {
        InitializeComponent();

        titleLayer.UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png";
    }

    private void LoadCustomMarkersButton_Clicked(object? sender, EventArgs e)
    {
        customMarkerStopwatch.Start();
        MapMarkerCollection markers = CreateCustomMarkers();

        titleLayer.Markers = markers;

        customMarkerStopwatch.Stop();

        CustomMarkerCountLabel.Text = $"Custom Marker Count: {markers.Count}";

        CustomMarkerTimeLabel.Text = $"Custom Marker Render Time: " + $"{customMarkerStopwatch.Elapsed.TotalMilliseconds:F0} ms";
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

                    HorizontalAlignment =
                        MapAlignment.Center,

                    VerticalAlignment =
                        MapAlignment.Start
                });
        }

        return markers;
    }
}