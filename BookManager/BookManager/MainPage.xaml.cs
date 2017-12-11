using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using ZXing.Mobile;
//using ZXing.Net.Mobile.Forms;

namespace BookManager
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Folder(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FolderMakePage());
        }
    }
}
