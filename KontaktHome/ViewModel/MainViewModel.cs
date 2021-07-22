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
            Categories.Add(new Category() { Name = "Phones"});
            Categories.Add(new Category() { Name = "Laptops" });
            Categories.Add(new Category() { Name = "Accesories" });
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
