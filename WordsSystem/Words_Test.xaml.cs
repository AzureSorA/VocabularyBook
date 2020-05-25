using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WordsSystem
{
    /// <summary>
    /// Interaction logic for Words_Test.xaml
    /// </summary>
    public partial class Words_Test : Window
    {
        database db = new database();
        string o = null;
        string t = null;
        public Words_Test()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            string dbName = "WordsDB.db";
            String Programpath = System.IO.Directory.GetCurrentDirectory();
            DirectoryInfo di = new DirectoryInfo(string.Format(@"{0}..\..\..\..\", Programpath));
            Programpath = di.FullName;
            dbName = Programpath + dbName;
            db.dbName = dbName;
            Current_dict.ItemsSource = db.Get_table_Name();
            
        }

        private void Bnext_Click(object sender, RoutedEventArgs e)
        {
            if(Current_dict.Text!="")
            {
                L_right_or_false.Content = "";
                Tanswer.Text = "";
                Image_right_or_false.Source = null;
                DataRow dr = db.Get_Random_Word(Current_dict.Text).Rows[0];
                o = dr["Original"].ToString();
                t = dr["Translation"].ToString();
                int[] number = { 0, 1 };
                Random r = new Random();
                int index = r.Next(number.Length);
                if(number[index]==0)
                {
                    Toriginal.Text = o;
                }
                else
                {
                    Toriginal.Text = t;
                    t = o;
                }
                Show_explanation.Text = "释义："+dr["Explanation"].ToString();
                Show_example.Text = "例句："+dr["Example"].ToString();
            }
        }

        private void Ttranslation_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if(Tanswer.Text==t)
                {
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.UriSource = new Uri(@"Resources/img/right.png", UriKind.RelativeOrAbsolute);
                    bi.EndInit();
                    Image_right_or_false.Source = bi;
                    L_right_or_false.Content = "答案正确";
                }
                else
                {
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.UriSource = new Uri(@"Resources/img/false.png", UriKind.RelativeOrAbsolute);
                    bi.EndInit();
                    Image_right_or_false.Source = bi;
                    L_right_or_false.Content = "答案错误,正确应为" + t;
                }
            }
        }
    }
}
