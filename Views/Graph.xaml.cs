using redsix.ViewModels;
using Syncfusion.Maui.Charts;
using System.Collections.ObjectModel;

namespace redsix.Views;

public partial class Graph : ContentPage
{
    [Obsolete]
    public Graph()
    {
        this.InitializeComponent();

        SfCircularChart chart = new SfCircularChart();
        SfCircularChart chart1 = new SfCircularChart();

        chart.Title = new Label
        {
            Text = "PRODUCT SALES",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            FontAttributes = FontAttributes.Bold
        };

        GraphVm viewModel = new GraphVm();
        chart.BindingContext = viewModel;

        chart.Legend = new ChartLegend();
        DoughnutSeries series = new DoughnutSeries();
        PieSeries series1 = new PieSeries();
        series.ExplodeIndex = 2;
        series.ExplodeRadius = 10;
        series.ExplodeOnTouch= true;    
        series.ItemsSource = viewModel.Data;
        series.XBindingPath = "Product";
        series.YBindingPath = "SalesRate";
        series.ShowDataLabels = true;
        series.EnableAnimation= true;

        chart.Series.Add(series);

        Content = chart;
    }
}