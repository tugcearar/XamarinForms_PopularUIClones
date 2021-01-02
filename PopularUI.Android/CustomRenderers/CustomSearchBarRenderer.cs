using Android.Content;
using Android.Widget;
using PopularUI.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SearchBar), typeof(CustomSearchBarRenderer))]

namespace PopularUI.Droid.CustomRenderers
{
    internal class CustomSearchBarRenderer : SearchBarRenderer
    {
        private Context _context;

        public CustomSearchBarRenderer(Context context) : base(context)
        {
            _context = context;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            var icon = Control?.FindViewById(_context.Resources.GetIdentifier("android:id/search_mag_icon", null, null));
            (icon as ImageView)?.SetColorFilter(Android.Graphics.Color.White);
        }
    }
}