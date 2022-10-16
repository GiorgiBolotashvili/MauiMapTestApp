using Esri.ArcGISRuntime.Mapping;
using ReactiveUI.Maui;

namespace MauiMapTestApp.Source.Presentation.MainPage;

public partial class MainPageView : ReactiveContentPage<MainPageViewModel>
{
	public MainPageView()
	{
        ViewModel = new MainPageViewModel();
        InitializeComponent();
        mapView.Map = new Esri.ArcGISRuntime.Mapping.Map(new Basemap(BasemapStyle.ArcGISTerrainDetail)
        {
            ApiKey = SecretApiKeys.ArcGisApiKey
        });
    }
}

