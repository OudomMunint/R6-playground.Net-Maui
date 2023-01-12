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
        itemcount = UserCollection.Count;
    }

    public void Nextpage(object sender, System.EventArgs e)
    {
        if (CarouselZoos.Position + 1 != itemcount)
        {
            CarouselZoos.Position = CarouselZoos.Position + 1;
        }
        else CarouselZoos.Position = 0;
        //CarouselZoos.Position++;
        //if (CarouselZoos.Position > itemcount) { CarouselZoos.Position = 0; }
    }

    public void Prepage(object sender, System.EventArgs e)
    {
        //Need to make this loop back to last index of array
        if (CarouselZoos.Position != 0)
        {
            CarouselZoos.Position = CarouselZoos.Position - 1;

            if (CarouselZoos.Position < 0) { CarouselZoos.Position = 4; }
        }
        //else CarouselZoos.Position--;

        //if (CarouselZoos.Position - 1 != itemcount)
        //{
        //    CarouselZoos.Position = CarouselZoos.Position - 1;
        //    if (itemcount < 0) { CarouselZoos.Position = 4; }
        //}
        //else CarouselZoos.Position = 4;

        //if (CarouselZoos.Position - 1 < itemcount)
        //{
        //    CarouselZoos.Position = CarouselZoos.Position - 1;
        //}
        //else CarouselZoos.Position = 4;

        //if (CarouselZoos.Position > itemcount)
        //{
        //    CarouselZoos.Position = CarouselZoos.Position - 1;
        //}
        //else CarouselZoos.Position = 4;
    }
}