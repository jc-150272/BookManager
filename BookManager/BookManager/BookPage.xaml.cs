using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        public BookPage()
        {
            ObservableCollection<Book> items = new ObservableCollection<Book>();
            items.Add(new Book { Name = "John Doe" });
            items.Add(new Book { Name = "Jane Doe" });
            items.Add(new Book { Name = "Sammy Doe" });
            BookListView.ItemsSource = items;
        }

        public class Book
        {
            public string Name { get; set; }
        }
    }
}