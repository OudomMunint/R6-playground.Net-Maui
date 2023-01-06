using System.Collections.ObjectModel;

namespace redsix.Views;

public partial class MoodSet : ContentPage
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
    public MoodSet()
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
}