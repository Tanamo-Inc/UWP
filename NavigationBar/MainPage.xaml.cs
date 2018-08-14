using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NavigationBar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            backBut.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Home));
            title.Text = "Home";
            home_item.IsSelected = true;

        }

        // Navigation Button Method.
        private void Nav_Button_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }



        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                home_item.IsSelected = true;
            }
        }


        //Navigation Listener Method.
        private void nav_view_listener(object sender, SelectionChangedEventArgs e)
        {
            if (home_item.IsSelected)
            {
                backBut.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Home));
               title.Text = "Home";
            }
            else if (news_item.IsSelected)
            {
                backBut.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(News));
                title.Text = "News";
            }




        }

    }
}
