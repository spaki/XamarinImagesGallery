using DLToolkit.Forms.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinImagesGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            FlowListView.Init();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
