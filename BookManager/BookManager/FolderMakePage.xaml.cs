using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookManager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FolderMakePage : ContentPage
    {
        public FolderMakePage()
        {
            InitializeComponent();
        }
        
        private void Storage(object sender, EventArgs e)
        {

        }
    }
}