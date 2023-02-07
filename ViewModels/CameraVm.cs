using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Media;
using Microsoft.Maui.Storage;
using System.IO;
using AndroidX.Navigation.UI;

namespace redsix.ViewModels;

public partial class ProfileOptionsPageVm : RedSixBaseVm
{
    public ProfileOptionsPageVm()
    {

    }
    public override void PageAppearing()
    {
        Console.WriteLine($"ProfilePrivacyPageViewModel PageAppearing");
    }

    [RelayCommand]
    private void SettingsButtonPressed()
    {
        NavigationUtil.Navigate<SettingsPage>();
    }

    [RelayCommand]
    private void PrivacySettingsButtonPressed()
    {
        NavigationUtil.Navigate<PrivacySettingsPage>();
    }

    [RelayCommand]
    private void MoodHistoryButtonPressed()
    {
        NavigationUtil.Navigate<MoodHistoryPage>();
    }

    [RelayCommand]
    private void DoneButtonPressed()
    {
        NavigationUtil.Navigate<SocialMainPage>();
    }

    [RelayCommand]
    private async void TakePhotoPressed()
    {
        NavigationUtil.Navigate<PhotoPickPage>();
    }


    [RelayCommand]
    private async void TakePhotoPressed2()
    {
        MediaPickerOptions options = new MediaPickerOptions();
        options.Title = "Add Attachment";

        // Convert FileResult from selected image to Base64 string
        FileResult result = await MediaPicker.Default.PickPhotoAsync(options);
        Stream imageStream = await result.OpenReadAsync();
        byte[] imageBytes;
        using (var memoryStream = new MemoryStream())
        {
            imageStream.CopyTo(memoryStream);
            imageBytes = memoryStream.ToArray();
        }

        string imageDataString = Convert.ToBase64String(imageBytes);

        ImageSource imageSource = ImageSource.FromFile(result.FullPath);

        RedSixData data = new RedSixData();
        //data.SetProfilePhoto(imageBytes);

        //SetProfilePhotoDTO ua = new SetProfilePhotoDTO();
        //ua.ProfileImageThumbnail =  imageBytes;

        var response = await data.SetProfilePhoto(imageBytes);

        if ((response != null) && (response.Success))
        {
            //Feed.Insert(0, response.Data);
            //NewFeedContent = string.Empty;
        }
        else
            ErrorHandler.HandleBaseResponseError<bool>(response);


    }
}
