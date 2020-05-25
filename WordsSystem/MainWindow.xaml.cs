using System.Windows;

namespace WordsSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Manage_Click(object sender, RoutedEventArgs e)
        {
            Manage_Dict m = new Manage_Dict();
            m.ShowDialog();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Search_word s = new Search_word();
            s.ShowDialog();
        }

        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Words_Test wt = new Words_Test();
            wt.ShowDialog();
        }
    }
}
