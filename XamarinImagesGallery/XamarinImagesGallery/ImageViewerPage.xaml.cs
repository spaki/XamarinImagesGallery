using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinImagesGallery
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageViewerPage : ContentPage
	{
        public ImageViewerPage(List<string> imagesUrls, string target)
        {
            InitializeComponent();

            imageViewer.ItemsSource = imagesUrls;
            imageViewer.SelectedIndex = imagesUrls.IndexOf(target);
        }
    }
}