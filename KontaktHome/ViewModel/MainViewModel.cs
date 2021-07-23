using KontaktHome.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KontaktHome.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Category> categories;
        public List<Category> Categories
        {
            get { return categories; }
            set { categories = value; OnPropertyChanged(); }
        }
        
        public MainViewModel()
        {
            Categories = new List<Category>();
            Categories.Add(new Category() { Name = "Telefonlar və Planşetlər", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/telefon_planshet.png" });
            Categories.Add(new Category() { Name = "Saatlar və qolbaqlar", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/saatlar_qolbaqlar.png" });
            Categories.Add(new Category() { Name = "TV, audio video", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/TV_audio_video.png" });
            Categories.Add(new Category() { Name = "Kompüter və aksesuarlar", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/komputer_ofis.png" });
            Categories.Add(new Category() { Name = "Foto və Video", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/foto_video.png" });
            Categories.Add(new Category() { Name = "Hobbi və Əyləncə", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/oyun_eylence.png" });
            Categories.Add(new Category() { Name = "Məişət texnikası", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/meishet.png" });
            Categories.Add(new Category() { Name = "Gözəllik və sağlamlıq", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/fen.png" });
            Categories.Add(new Category() { Name = "Alətlər və Avtomobil məhsulları", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/elektrik-aletler_avtomobil.png" });
            Categories.Add(new Category() { Name = "Ev və bağ", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/bag_ev.png" });
            Categories.Add(new Category() { Name = "Mebel və Ev tekstili", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/mebel.png" });
            Categories.Add(new Category() { Name = "Ofis avadanlıqları", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/mekteb.png" });
            Categories.Add(new Category() { Name = "Uşaq aləmi", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/ushaq.png" });
            Categories.Add(new Category() { Name = "Hədiyyə və Bonus kartları", ImageUrl = "https://kontakt.az/wp-content/uploads/2021/03/hediyye_karti.png" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
