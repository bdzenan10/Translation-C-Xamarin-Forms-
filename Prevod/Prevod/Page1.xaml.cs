using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prevod
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public IList<Sura> sure { get; private set; }
        public Page1()
        {
            InitializeComponent();
            sure = new List<Sura>();
            sure.Add(new Sura
            {
                redniBroj = 1,
                naslov = "El-Fātiha – Pristup",
                tekst = "Tebe, Allaha, Gospodara svjetova, hvalimo, Milostivog, Samilosnog, Vladara Dana sudnjeg,Tebi se klanjamo i od Tebe pomoć tražimo! Uputi nas na Pravi pna Put onih kojima si milost Svoju darovao, a ne onih koji su protiv sebe srdžbu izazvali, niti onih koji su zalutali!  "
              

              
                
            });
            sure.Add(new Sura
            {
                redniBroj = 2,
                naslov = "El-Bekare – Krava",
                



            });
            
            
            BindingContext = this;
        }

        private void listview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tekst = e.Item as Sura;
             Navigation.PushAsync(new Page2(tekst));
        }
    }
}