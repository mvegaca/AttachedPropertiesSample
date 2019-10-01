using System.Collections.ObjectModel;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AttachedPropertiesSample.Behaviors
{
    public class ListViewBehavior : Behavior<ListView>
    {
        public static Collection<string> GetListViewItems(Page item)
        {
            return (Collection<string>)item.GetValue(ListViewItemsProperty);
        }

        public static void SetListViewItems(Page item, Collection<string> value)
        {
            item.SetValue(ListViewItemsProperty, value);
        }

        public static readonly DependencyProperty ListViewItemsProperty =
            DependencyProperty.RegisterAttached("ListViewItems", typeof(Collection<string>), typeof(ListViewBehavior), new PropertyMetadata(new Collection<string>(), OnListViewItemsPropertyChanged));

        protected override void OnAttached()
        {
            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
        }

        internal void Initialize(Frame navigationFrame)
        {
            navigationFrame.Navigated += OnNavigated;
        }

        private void OnNavigated(object sender, NavigationEventArgs e)
        {
            // Clear all ListView Items
            AssociatedObject.Items.Clear();

            var page = e.Content as Page;

            // THE ISSUE
            //
            // This should get the items provided from the navigated page,
            // instead of that, it gets items provided for all pages in the navigation history
            var items = GetListViewItems(page);
            foreach (var item in items)
            {
                AssociatedObject.Items.Add(item);
            }
        }

        private static void OnListViewItemsPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // This should be called when the property is dynamically updated
            //
            // This should be never called on this project
            // because ListViewItems are statically set from XAML
        }
    }
}
