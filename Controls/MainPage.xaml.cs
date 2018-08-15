using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Controls
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


        //CheckBox Method
        private void checker_tap(object sender, TappedRoutedEventArgs e)
        {
            disp_checker.Text = checker.IsChecked.ToString();
        }

        //RadioButton Method
        private void checker_radio(object sender, RoutedEventArgs e)
        {
            disp_radio.Text = (bool)YesRadioButton.IsChecked ? "Yes" : "No";
        }

        //ComboBox Method
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (disp_combo == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;

            disp_combo.Text = item.Content.ToString();

        }

        //ListBox Method
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = MyListBox.Items.Cast<ListBoxItem>()
                                  .Where(p => p.IsSelected)
                                    .Select(t => t.Content.ToString())
                                      .ToArray();

            disp_list.Text = string.Join(", ", selectedItems);

        }

        //ToggleButton Method
        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            disp_toggle.Text = MyToggleButton.IsChecked.ToString();
        }


    }
}
