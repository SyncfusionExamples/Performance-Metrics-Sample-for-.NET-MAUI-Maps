# Performance Metrics Sample for Syncfusion .NET MAUI Maps

This repository provides a quick-start example for analyzing the performance of the Syncfusion .NET MAUI Maps control using **Shape Layer** and **Tile Layer** samples.

Each sample contains the following scenarios:

1. Map load time
2. Default marker rendering with 100 markers
3. Custom marker rendering with 100 markers
4. Zoom performance

The scenarios are implemented on separate pages:

```text
MainPage.xaml          - Shape Layer or Tile Layer load time
DefaultMarkerPage.xaml - 100 default markers
CustomMarkerPage.xaml  - 100 custom markers
ZoomPage.xaml          - Zoom performance
```

## Steps to Run the Demo

**Step 1:** Clone or download the repository.

**Step 2:** Open the required Shape Layer or Tile Layer project in your preferred IDE.

**Step 3:** Open `AppShell.xaml`.

**Step 4:** Change the `ShellContent` page in `AppShell.xaml` based on the scenario you want to run.

### Shape Layer or Tile Layer Load Time

Use `MainPage`:

```xml
<ShellContent
    Title="Load Time"
    ContentTemplate="{DataTemplate local:MainPage}"
    Route="MainPage" />
```

In the Shape Layer project, `MainPage` displays the **Shape Layer load time**.

In the Tile Layer project, `MainPage` displays the **Tile Layer load time**.

Select the button on `MainPage` to run the load-time scenario and read the displayed elapsed value.

### Default Marker Rendering

Replace the existing `ShellContent` with `DefaultMarkerPage`:

```xml
<ShellContent
    Title="Default Marker"
    ContentTemplate="{DataTemplate local:DefaultMarkerPage}"
    Route="DefaultMarkerPage" />
```

This scenario measures the time required to render **100 default markers**.

### Custom Marker Rendering

Replace the existing `ShellContent` with `CustomMarkerPage`:

```xml
<ShellContent
    Title="Custom Marker"
    ContentTemplate="{DataTemplate local:CustomMarkerPage}"
    Route="CustomMarkerPage" />
```

This scenario measures the time required to render **100 custom markers**.

The Default Marker and Custom Marker scenarios use the same marker locations for a consistent comparison.

### Zoom Performance

Replace the existing `ShellContent` with `ZoomPage`:

```xml
<ShellContent
    Title="Zoom Performance"
    ContentTemplate="{DataTemplate local:ZoomPage}"
    Route="ZoomPage" />
```

This scenario measures the total elapsed time for the predefined zoom operations.

**Step 5:** Build and run the project using the **Release** configuration.

**Step 6:** Select the button on the selected page to run the scenario.

**Step 7:** Read the elapsed value displayed after the scenario completes.

> Run only one scenario page at a time. To test another scenario, stop the application, update the `ShellContent` entry in `AppShell.xaml`, rebuild, and run the project again.

## Output

### Shape Layer Load Time

<img width="1909" height="917" alt="Shape Layer load-time result" src="https://github.com/user-attachments/assets/003bc275-5c12-4a13-919b-4dd311e48f90" />

### Tile Layer Load Time

<img width="1906" height="873" alt="Tile Layer load-time result" src="https://github.com/user-attachments/assets/f27fc462-178a-4d2d-b27c-19791124df33" />

## Sample Results

The following values were recorded for the Shape Layer and Tile Layer scenarios.

| S.No | Layer | Load Time (ms) | Default Marker (ms) | Custom Marker (ms) | Zoom (ms) |
|---:|---|---:|---:|---:|---:|
| 1 | Tile Layer | 58 | 12 | 159 | 37 |
| 2 | Shape Layer | 50 | 11 | 160 | 13 |

## Specifications

| Specification | Value |
|---|---|
| .NET version | .NET 10.0 |
| Syncfusion Maps version | Add installed version |
| Build configuration | Release |
| RAM | 16GB |

## Troubleshooting

### Path Too Long Exception

If a path-too-long exception occurs while building the sample, close the IDE, move or rename the repository to a shorter path, reopen the project, and rebuild it.