using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinImagesGallery
{
    public partial class MainPage : ContentPage
    {
        List<string> imagesInfo = new List<string> {
            "https://abrilquatrorodas.files.wordpress.com/2018/07/mercedes-classe-c-sedan-1.jpg?quality=70&strip=info&strip=info", 
            "https://s2.glbimg.com/W4KIN58gvos0FAHtzxRoMbyQuBs=/620x413/e.glbimg.com/og/ed/f/original/2018/10/30/classeafrenteessa.jpg", 
            "http://www.portalautoshopping.com.br/blog/wp-content/uploads/2017/03/exemplo-de-sedan-grande-diferen%C3%A7a-entre-hatch-e-sedan-1-1024x676.jpg", 
            "https://st.motortrend.com/uploads/sites/10/2017/01/2017-hyundai-azera-limited-sedan-angular-front.png", 
            "https://abrilquatrorodas.files.wordpress.com/2018/10/imagem-12-e1539263029467.jpg?quality=70&strip=info&strip=info", 
            "https://cdn-motorshow-ssl.akamaized.net/wp-content/uploads/sites/2/2018/09/jeep-compass-sport-eua-e1536097009579.jpg", 
            "https://www.ourismancdjalexandria.com/assets/shared/CustomHTMLFiles/Responsive/MRP/Jeep/2018/Compass/images/2018-Jeep-Compass-01.jpg", 
            "https://cdn-motorshow-ssl.akamaized.net/wp-content/uploads/sites/2/2017/12/23_ms413_equinox-compass-3008_3-e1515083994209.jpg", 
            "https://images.immedia.com.br//22/22810_2_EL.jpg?c=201806051140", 
            "https://cdn.cyrela.com.br/Files/Imagens/Imoveis/2091/destaque/130863767826047625_1944x1080-16terraco-apartamento.jpg", 
            "http://s2.glbimg.com/4q8g20CA2E_GmddMiMjVgOmjiIg=/smart/e.glbimg.com/og/ed/f/original/2015/08/18/apartamento-santa-catarina-espaco-traco-arquitetura-02.jpg", 
            "https://resizedimgs.vivareal.com/fit-in/870x653/vr.images.sp/91bbc5e8636edf2a25341a81606b902e.jpg" 
        };

        public MainPage()
        {
            InitializeComponent();
            gallery.FlowItemsSource = imagesInfo;
        }

        private async void Gallery_FlowItemTapped(object sender, ItemTappedEventArgs e) => await Navigation.PushAsync(new ImageViewerPage(imagesInfo, (string)e.Item));
    }
}
