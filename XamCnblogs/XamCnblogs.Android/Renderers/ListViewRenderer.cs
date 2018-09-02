using Android.Content;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Widget;
using Xamarin.Forms;
using XamCnblogs.Droid.Renderers;
using XamCnblogs.UI.Controls;
using static Android.Widget.AbsListView;
using AListView = Android.Widget.ListView;

[assembly: ExportRenderer(typeof(LoadMoreListView), typeof(LoadMoreListViewRenderer))]
namespace XamCnblogs.Droid.Renderers
{
    public class LoadMoreListViewRenderer : Xamarin.Forms.Platform.Android.ListViewRenderer, Android.Widget.AbsListView.IOnScrollListener
    {
        private bool scrollFlag = false;// Mark whether it scrolls
        private int lastVisibleItemPosition = 0;// Mark lastVisibleItemPosition
        private HomeTabbedPage HomePage;
        public LoadMoreListViewRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var aListView = (AListView)Control;
                aListView.VerticalScrollBarEnabled = false;
                aListView.SetOnScrollListener(this);
                var _refresh = (SwipeRefreshLayout)aListView.Parent;
                if (_refresh != null)
                {
                    _refresh.SetColorSchemeResources(Resource.Color.primary);
                }
                HomePage = this.Element.Parent.Parent.Parent as HomeTabbedPage;
            }
        }

        public void OnScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount)
        {
            if (scrollFlag)
            {
                if (firstVisibleItem > lastVisibleItemPosition)
                {
                    // Slippery //Up
                    if (HomePage != null)
                    {
                        HomePage.ToggleFloatingActionButton = true;
                    }
                }
                else if (firstVisibleItem < lastVisibleItemPosition)
                {
                    // Sliding //down
                    if (HomePage != null)
                    {
                        HomePage.ToggleFloatingActionButton = false;
                    }
                }
                else
                {
                    return;
                }
                lastVisibleItemPosition = firstVisibleItem;
            }
        }

        public void OnScrollStateChanged(AbsListView view, [GeneratedEnum] ScrollState scrollState)
        {
            switch (scrollState)
            {
                // When not scrolling
                case ScrollState.Idle:// when the screen stops scrolling
                    scrollFlag = false;
                    break;
                case ScrollState.TouchScroll:// screen scrolling
                    scrollFlag = true;
                    break;
                case ScrollState.Fling:// Is when the user swipes the screen and lifts the finger，When the screen produces inertial sliding

                    scrollFlag = false;
                    break;
            }
        }
    }
}