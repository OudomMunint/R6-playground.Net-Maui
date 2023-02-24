using redsix.ViewModels;
using Syncfusion.Maui.Charts;
using System.Collections.ObjectModel;

namespace redsix.Views;

public partial class Graph : ContentPage
{
    public Graph()
    {
        this.InitializeComponent();

        SfCircularChart chart = new SfCircularChart();

        GraphVm viewModel = new GraphVm();
        chart.BindingContext = viewModel;

        chart.Legend = new ChartLegend();
        PieSeries series = new PieSeries();
        series.ItemsSource = viewModel.Data;
        series.XBindingPath = "Product";
        series.EnableTooltip = true;
        series.ShowDataLabels = true;
        series.YBindingPath = "SalesRate";

        chart.Series.Add(series);

        Content = chart;
    }
}