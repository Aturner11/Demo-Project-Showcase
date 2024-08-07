using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !ListNames.Items.Contains(txtName.Text))
            {
                ListNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }

        private void ListNames_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }

}







