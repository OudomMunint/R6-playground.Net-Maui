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
    }

    public void Nextpage(object sender, System.EventArgs e)
    {
        if (CarouselZoos.Position + 1 != itemcount)
        {
            CarouselZoos.Position = CarouselZoos.Position + 1;
        }
    }

    public void Prepage(object sender, System.EventArgs e)
    {
        if (CarouselZoos.Position != 0)
        {
            CarouselZoos.Position = CarouselZoos.Position - 1;
        }
    }
}