using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace redsix.Views;

public partial class Carosel : ContentPage
{
    public class UserInformation
    {
        public ImageSource UserImage { get; set; }

    }
    private ObservableCollection<UserInformation> userCollection;
    public ObservableCollection<UserInformation> UserCollection
    {
        get { return userCollection; }
        set
        {
            userCollection = value;
            OnPropertyChanged();
        }
    }
    private int itemcount;
    public Carosel()
	{
		InitializeComponent();
        BindingContext = this;
        UserCollection = new ObservableCollection<UserInformation>
            {
                new UserInformation{UserImage = "mood2.png"},
                new UserInformation{UserImage = "mood4.png"},
                new UserInformation{UserImage = "mood3.png"},
                new UserInformation{UserImage = "moodsad.png"},
            };

        //var images = new ObservableCollection<Image>();
        //    {
        //    images.Add(new Image { Source = ImageSource.FromFile("mood2.png") });
        //    images.Add(new Image { Source = ImageSource.FromFile("mood4.png") });
        //    images.Add(new Image { Source = ImageSource.FromFile("mood3.png") });
        //    images.Add(new Image { Source = ImageSource.FromFile("moodsad.png") });
        //};
        //CarouselZoos.ItemsSource = images;

        itemcount = UserCollection.Count;
    }

    public void Nextpage(object sender, System.EventArgs e)
    {
        if (CarouselZoos.Position == itemcount - 1)
        {
            CarouselZoos.Position = 0;
        }
        else if (CarouselZoos.Position < itemcount - 1)
        {
            CarouselZoos.Position++;
        }
    }

    public void Prepage(object sender, System.EventArgs e)
    {
        if (CarouselZoos.Position == 0)
        {
            CarouselZoos.Position = itemcount - 1;
        }
        else if (CarouselZoos.Position > 0)
        {
            CarouselZoos.Position--;
        }
    }
}