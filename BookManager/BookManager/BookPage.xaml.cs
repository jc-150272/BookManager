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
            InitializeComponent();

            ObservableCollection<Book> items = new ObservableCollection<Book>();
            items.Add(new Book { Name = "John Doe" ,Value = 4.0 });
            items.Add(new Book { Name = "Jane Doe" ,Value = 3.5 });
            items.Add(new Book { Name = "Sammy Doe" ,Value = 2.5});

            if(Value <= 0.25)
            {
                ValueImage = "value_0.gif";
            }

            else if(Value <= 0.75)
            {
                ValueImage = "value_0.5.gif";
            }

            else if (Value <= 0.125)
            {
                ValueImage = "value_1.gif";
            }

            else if (Value <= 0.175)
            {
                ValueImage = "value_1.5.gif";
            }

            else if (Value <= 0.225)
            {
                ValueImage = "value_2.gif";
            }

            else if (Value <= 0.275)
            {
                ValueImage = "value_2.5.gif";
            }

            else if (Value <= 0.325)
            {
                ValueImage = "value_3.gif";
            }

            else if (Value <= 0.375)
            {
                ValueImage = "value_3.5.gif";
            }

            else if (Value <= 0.425)
            {
                ValueImage = "value_4.gif";
            }

            else if (Value <= 0.475)
            {
                ValueImage = "value_4.5.gif";
            }

            else 
            {
                ValueImage = "value_5.gif";
            }

            BookListView.ItemsSource = items;

        }

        public class Book
        {
            public string Name { get; set; }

            public double Value { get; set; }

            public string ValueImage { get; set; }
        }
    }
}