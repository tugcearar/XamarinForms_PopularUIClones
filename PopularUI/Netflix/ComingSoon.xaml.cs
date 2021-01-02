using PopularUI.Data;
using System.Collections.ObjectModel;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopularUI.Netflix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComingSoon : ContentPage
    {
        private bool middle;

        public ComingSoon()
        {
            InitializeComponent();
        }

        private void ListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var listView = sender as ListView;
            if (e.Item == (listView.ItemsSource as ObservableCollection<SoonMovie>).LastOrDefault())
            {
                //listView.ScrollTo(e.Item, ScrollToPosition.MakeVisible, false);
            }
        }
    }
}