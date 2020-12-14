using PokedexApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PokedexApp.Views
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