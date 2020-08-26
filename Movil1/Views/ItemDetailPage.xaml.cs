using System.ComponentModel;
using Xamarin.Forms;
using Movil1.ViewModels;

namespace Movil1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}