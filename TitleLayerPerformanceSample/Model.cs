namespace TitleLayerPerformanceSample;

public sealed class CountryLocation
{
    public CountryLocation(string countryName, double latitude, double longitude)
    {
        CountryName = countryName;
        Latitude = latitude;
        Longitude = longitude;
    }

    public string CountryName { get; }

    public double Latitude { get; }

    public double Longitude { get; }
}

public static class CountryLocationData
{
    public static IReadOnlyList<CountryLocation> Countries { get; } =
    [
    new("India", 20.5937, 78.9629),
    new("United States", 37.0902, -95.7129),
    new("Canada", 56.1304, -106.3468),
    new("Brazil", -14.2350, -51.9253),
    new("United Kingdom", 55.3781, -3.4360),
    new("France", 46.2276, 2.2137),
    new("Germany", 51.1657, 10.4515),
    new("China", 35.8617, 104.1954),
    new("Japan", 36.2048, 138.2529),
    new("Australia", -25.2744, 133.7751),

    new("Italy", 41.8719, 12.5674),
    new("Spain", 40.4637, -3.7492),
    new("Portugal", 39.3999, -8.2245),
    new("Norway", 60.4720, 8.4689),
    new("Sweden", 60.1282, 18.6435),
    new("Finland", 61.9241, 25.7482),
    new("Denmark", 56.2639, 9.5018),
    new("Poland", 51.9194, 19.1451),
    new("Netherlands", 52.1326, 5.2913),
    new("Belgium", 50.5039, 4.4699),

    new("Switzerland", 46.8182, 8.2275),
    new("Austria", 47.5162, 14.5501),
    new("Ireland", 53.1424, -7.6921),
    new("Greece", 39.0742, 21.8243),
    new("Turkey", 38.9637, 35.2433),
    new("Russia", 61.5240, 105.3188),
    new("Ukraine", 48.3794, 31.1656),
    new("Romania", 45.9432, 24.9668),
    new("Hungary", 47.1625, 19.5033),
    new("Czech Republic", 49.8175, 15.4730),

    new("South Korea", 35.9078, 127.7669),
    new("Indonesia", -0.7893, 113.9213),
    new("Malaysia", 4.2105, 101.9758),
    new("Singapore", 1.3521, 103.8198),
    new("Thailand", 15.8700, 100.9925),
    new("Vietnam", 14.0583, 108.2772),
    new("Philippines", 12.8797, 121.7740),
    new("Pakistan", 30.3753, 69.3451),
    new("Bangladesh", 23.6850, 90.3563),
    new("Sri Lanka", 7.8731, 80.7718),

    new("Nepal", 28.3949, 84.1240),
    new("Myanmar", 21.9162, 95.9560),
    new("Mongolia", 46.8625, 103.8467),
    new("Afghanistan", 33.9391, 67.7100),
    new("Iran", 32.4279, 53.6880),
    new("Iraq", 33.2232, 43.6793),
    new("Saudi Arabia", 23.8859, 45.0792),
    new("United Arab Emirates", 23.4241, 53.8478),
    new("Israel", 31.0461, 34.8516),
    new("Jordan", 30.5852, 36.2384),

    new("Egypt", 26.8206, 30.8025),
    new("South Africa", -30.5595, 22.9375),
    new("Nigeria", 9.0820, 8.6753),
    new("Kenya", -0.0236, 37.9062),
    new("Ethiopia", 9.1450, 40.4897),
    new("Morocco", 31.7917, -7.0926),
    new("Algeria", 28.0339, 1.6596),
    new("Tunisia", 33.8869, 9.5375),
    new("Ghana", 7.9465, -1.0232),
    new("Tanzania", -6.3690, 34.8888),

    new("Uganda", 1.3733, 32.2903),
    new("Zimbabwe", -19.0154, 29.1549),
    new("Zambia", -13.1339, 27.8493),
    new("Mozambique", -18.6657, 35.5296),
    new("Madagascar", -18.7669, 46.8691),
    new("Angola", -11.2027, 17.8739),
    new("Cameroon", 7.3697, 12.3547),
    new("Sudan", 12.8628, 30.2176),
    new("Senegal", 14.4974, -14.4524),
    new("Botswana", -22.3285, 24.6849),

    new("Mexico", 23.6345, -102.5528),
    new("Argentina", -38.4161, -63.6167),
    new("Chile", -35.6751, -71.5430),
    new("Peru", -9.1900, -75.0152),
    new("Colombia", 4.5709, -74.2973),
    new("Venezuela", 6.4238, -66.5897),
    new("Ecuador", -1.8312, -78.1834),
    new("Bolivia", -16.2902, -63.5887),
    new("Paraguay", -23.4425, -58.4438),
    new("Uruguay", -32.5228, -55.7658),

    new("Cuba", 21.5218, -77.7812),
    new("Jamaica", 18.1096, -77.2975),
    new("Panama", 8.5380, -80.7821),
    new("Costa Rica", 9.7489, -83.7534),
    new("Guatemala", 15.7835, -90.2308),
    new("Honduras", 15.2000, -86.2419),
    new("El Salvador", 13.7942, -88.8965),
    new("Nicaragua", 12.8654, -85.2072),
    new("Belize", 17.1899, -88.4976),
    new("Dominican Republic", 18.7357, -70.1627),

    new("New Zealand", -40.9006, 174.8860),
    new("Papua New Guinea", -6.3150, 143.9555),
    new("Fiji", -17.7134, 178.0650),
    new("Solomon Islands", -9.6457, 160.1562),
    new("Vanuatu", -15.3767, 166.9592),
    new("Tonga", -21.1790, -175.1982),
    new("Samoa", -13.7590, -172.1046),
    new("Timor-Leste", -8.8742, 125.7275),
    new("Cambodia", 12.5657, 104.9910),
    new("Laos", 19.8563, 102.4955)
    ];
}