using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace WordsSystem
{
    class database
    {
        public string dbName { get; set; } = "null";
        private bool status = false;
        //新建表
        public bool Create_table(string tablename)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "create table if not exists " + tablename + "(ID integer primary key not null,Original TEXT,Translation TEXT,Explanation TEXT,Example TEXT)";
                cmd.ExecuteNonQuery();
                status = true;
                dbConnection.Close();
            }
            return status;
        }
        //获取数据库的表名
        public List<string> Get_table_Name()
        {
            List<string> tablename = new List<string>();
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                string text = "select * from sqlite_master where type='table' order by name;";
                SQLiteCommand cmd = new SQLiteCommand(text, dbConnection);
                SQLiteDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    if(dr.GetString(1)!= "sqlite_sequence")
                    {
                        tablename.Add(dr.GetString(1));
                    }
                }
                dbConnection.Close();
            }
            return tablename;
        }
        //删除表
        public bool Delete_table(string tablename)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                string text = "drop table if exists " + tablename;
                SQLiteCommand cmd = new SQLiteCommand(text,dbConnection);
                cmd.ExecuteNonQuery();
                dbConnection.Close();
                status = true;
            }
            return status;
        }
        //插入单词
        public bool Insert_word(string tablename,string ID,string o,string t,string e,string example)
        {
            int id = 0;
            id = int.Parse(ID);
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            string[] os = o.Split(";");
            string[] ts = t.Split(";");
            string[] es = e.Split(";");
            string[] examples = example.Split(";");
            if((os.Length&ts.Length&es.Length&examples.Length)!=os.Length)
            {
                return status;
            }
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "insert into " + tablename +
                    "(ID,Original,Translation,Explanation,Example) values(@ID,@Original,@Translation,@Explanation,@Example)";
                for(int i=0;i<os.Length;i++)
                {
                    cmd.Parameters.Add("ID", DbType.Int32).Value = id;
                    cmd.Parameters.Add("Original", DbType.String).Value = os[i];
                    cmd.Parameters.Add("Translation", DbType.String).Value = ts[i];
                    cmd.Parameters.Add("Explanation", DbType.String).Value = es[i];
                    cmd.Parameters.Add("Example", DbType.String).Value = examples[i];
                    cmd.ExecuteNonQuery();
                    id++;
                }                
                dbConnection.Close();
                status = true;
            }
            return status;
        }
        //更新单词
        public bool Update_word(string tablename,string id, string o, string t, string e, string example)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "update " + tablename + 
                    " set Original=@Original,Translation=@Translation,Explanation=@Explanation,Example=@Example where ID=" + id;
                cmd.Parameters.Add("Original", DbType.String).Value = o;
                cmd.Parameters.Add("Translation", DbType.String).Value = t;
                cmd.Parameters.Add("Explanation", DbType.String).Value = e;
                cmd.Parameters.Add("Example", DbType.String).Value = example;
                cmd.ExecuteNonQuery();
                dbConnection.Close();
            }
            return status;
        }
        //删除单词
        public bool Delete_word(string tablename,string id)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                string text = "delete from " + tablename + " where id='" + id + "'";
                SQLiteCommand cmd = new SQLiteCommand(text, dbConnection);
                cmd.ExecuteNonQuery();
                dbConnection.Close();
                status = true;
            }
            return status;
        }
        //搜索单词
        public DataView Search_word(string tablename,string search_word,string type)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            DataTable dt = new DataTable(tablename);
            string command = "";
            if (type == "Original")
            {
                command = "select * from " + tablename + " where Original like '%" + search_word + "%'";
            }
            else if (type == "Translation")
            {
                command = "select * from " + tablename + " where Translation like '%" + search_word + "%'";
            }
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                SQLiteCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = command;
                SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);
                data.Fill(dt);
                dbConnection.Close();
            }
            return dt.DefaultView;
        }
        //显示当前词库的单词
        public DataView Display_Current_Dict(string tablename)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            DataTable dt = new DataTable(tablename);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                SQLiteCommand cmd = dbConnection.CreateCommand();
                string command = "select * from " + tablename;
                cmd.CommandText = command;
                SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);                
                data.Fill(dt);
                dbConnection.Close();
            }
            return dt.DefaultView;
        }
        //得到当前词库的单词
        public DataTable Get_Random_Word(string tablename)
        {
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            DataTable dt = new DataTable(tablename);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                SQLiteCommand cmd = dbConnection.CreateCommand();
                //string command = "select * from " + tablename + " order by random() limit 1";
                string command = "SELECT * FROM "+tablename+" ORDER BY RANDOM() LIMIT 1";
                cmd.CommandText = command;
                SQLiteDataAdapter data = new SQLiteDataAdapter(cmd);
                data.Fill(dt);
                dbConnection.Close();
            }
            return dt;
        }
        //计算该表格的行数
        public string Count_table_row(string tablename)
        {
            string num = null;
            SQLiteConnection dbConnection = new SQLiteConnection("data source=" + dbName);
            if (dbConnection.State != System.Data.ConnectionState.Open)
            {
                dbConnection.Open();
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = dbConnection;
                cmd.CommandText = "select count(*) from " + tablename;
                SQLiteDataReader sr = cmd.ExecuteReader();
                sr.Read();
                num = (sr.GetInt32(0) + 1).ToString();
                sr.Close();
                dbConnection.Close();
            }  
            return num;
        }
    }
}
