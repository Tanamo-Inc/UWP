using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        // XAML - XML Syntax, create instances of Classes that define the UI.
       // XAML is a declarative markup language.





        // Button Click Method.
        private void ClickBut_Click(object sender, RoutedEventArgs e)
        {
            display.Text = "Hello World";

        }

    }
}
