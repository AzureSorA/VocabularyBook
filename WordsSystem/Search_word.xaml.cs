using System;
using System.IO;
using System.Windows;


namespace WordsSystem
{
    /// <summary>
    /// Interaction logic for Add_Word.xaml
    /// </summary>
    public partial class Search_word : Window
    {
        database db = new database();
        public Search_word()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            string dbName = "WordsDB.db";
            String Programpath = System.IO.Directory.GetCurrentDirectory();
            DirectoryInfo di = new DirectoryInfo(string.Format(@"{0}..\..\..\..\", Programpath));
            Programpath = di.FullName;
            dbName = Programpath + dbName;
            db.dbName = dbName;
            CB_current_dict.ItemsSource = db.Get_table_Name();
        }

        private void CB_current_dict_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            datagrid.ItemsSource = db.Display_Current_Dict(CB_current_dict.SelectedValue.ToString());
        }

        private void Bsearch_translation_Click(object sender, RoutedEventArgs e)
        {
            if(Tsearch.Text=="")
            {
                datagrid.ItemsSource = db.Display_Current_Dict(CB_current_dict.Text);
            }
            else
            {
                datagrid.ItemsSource = db.Search_word(CB_current_dict.Text, Tsearch.Text, "Translation");
            }
        }

        private void Bsearch_original_Click(object sender, RoutedEventArgs e)
        {
            if (Tsearch.Text == "")
            {
                datagrid.ItemsSource = db.Display_Current_Dict(CB_current_dict.Text);
            }
            else
            {
                datagrid.ItemsSource = db.Search_word(CB_current_dict.Text, Tsearch.Text, "Original");
            }
        }
    }
}
