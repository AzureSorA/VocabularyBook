using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace WordsSystem
{
    /// <summary>
    /// Interaction logic for Manage_Dict.xaml
    /// </summary>
    public partial class Manage_Dict : Window
    {
        database db = new database();
        public Manage_Dict()
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
        
        private void Create_dict_Click(object sender, RoutedEventArgs e)
        {
            if(Create_Table_Name.Text=="")
            {
                MessageBox.Show("表名不能为空");
            }
            else if(db.Create_table(Create_Table_Name.Text))
            {
                Current_dict.ItemsSource = db.Get_table_Name();
                MessageBox.Show("已成功创建词库" + Create_Table_Name.Text + ".");
                Create_Table_Name.Text = "";
            }
            else
            {
                MessageBox.Show("创建失败，请重试");
            }
        }
        
        private void Delete_dict_Click(object sender, RoutedEventArgs e)
        {
            if(Current_dict.Text==null)
            {
                MessageBox.Show("没有选择要删除的表");
            }
            else
            {
                if(db.Delete_table(Current_dict.Text))
                {
                    Current_dict.Text = null;
                    Current_dict.ItemsSource = db.Get_table_Name();
                    MessageBox.Show("已成功删除" + Current_dict.Text + "词库");
                }
            }
        }
        //有瑕疵，执行删除事件后，再次触发选择改变事件时，datagrid没有显示相对应的词库
        private void Current_dict_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Current_dict.Text == null)
            {
                datagrid.ItemsSource = null;
            }
            else
            {
                datagrid.ItemsSource = db.Display_Current_Dict(Current_dict.SelectedValue.ToString());
            }
        }

        private void Add_word_Click(object sender, RoutedEventArgs e)
        {
            string id = db.Count_table_row(Current_dict.Text);
            if (id!="1")
            {
                id =(datagrid.Columns[0].GetCellContent(datagrid.Items[int.Parse(id) - 2]) as TextBlock).Text;
                id = (int.Parse(id) + 1).ToString();
            }
            if(db.Insert_word(Current_dict.Text, id, Toriginal.Text, Ttranslation.Text, Texplanation.Text, Texample.Text))
            {
                Toriginal.Text = "";
                Ttranslation.Text = "";
                Texplanation.Text = "";
                Texample.Text = "";
                MessageBox.Show("添加单词成功");
                datagrid.ItemsSource = db.Display_Current_Dict(Current_dict.Text);
            }
            else
            {
                MessageBox.Show("添加格式不对，请重试");
            }
        }

        private void Delete_word_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dr = datagrid.SelectedItem as DataRowView;
            if(dr!=null)
            {
                db.Delete_word(Current_dict.Text, dr["ID"].ToString());
                MessageBox.Show("删除单词成功");
                datagrid.ItemsSource = db.Display_Current_Dict(Current_dict.Text);
            }
        }

        private void Bclean_Click(object sender, RoutedEventArgs e)
        {
            Toriginal.Text = "";
            Ttranslation.Text = "";
            Texplanation.Text = "";
            Texample.Text = "";
        }

        private void Bupdate_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dr = datagrid.SelectedItem as DataRowView;
            if(dr!=null)
            {
                db.Update_word(Current_dict.Text, dr["ID"].ToString(), Toriginal.Text, Ttranslation.Text, Texplanation.Text, Texample.Text);
                MessageBox.Show("更新成功");
                datagrid.ItemsSource = db.Display_Current_Dict(Current_dict.Text);
            }
            
        }

        private void Bselected_update_word_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dr = datagrid.SelectedItem as DataRowView;
            if(dr!=null)
            {
                Toriginal.Text = dr["Original"].ToString();
                Ttranslation.Text = dr["Translation"].ToString();
                Texplanation.Text = dr["Explanation"].ToString();
                Texample.Text = dr["Example"].ToString();
            }
        }
    }
}
