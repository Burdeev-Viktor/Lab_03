using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class DatabaseHendler
    {
       private static string dbHost = "127.0.0.1";
       private static string dbPort = "3306";
       private static string dbUser = "root";
       private static string dbPassword = "12345";
       
       private static string dbTableName = "monsters";
       private static string dbId = "idmonsters";
       private static string dbName = "namme";
       private static string dbGenus = "genus";
       private static string dbDrop = "dropp";
       private static string dbDander = "danger";
       private MySqlConnection _connection = new MySqlConnection("server="+dbHost+";port="+dbPort+";username="+dbUser+";password="+dbPassword+";database="+dbTableName);

        public void openDatabase()
        {
           if (_connection.State == System.Data.ConnectionState.Closed)
           {
              _connection.Open();
           }
        }

        public void closeDatabase()
        {
           if (_connection.State == System.Data.ConnectionState.Open)
           {
              _connection.Close();
           }
        }

        public MySqlConnection GetConnection()
        {
           return _connection;
        }

        public List<Monster> get()
        {
           DataTable table = new DataTable();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           MySqlCommand command = new MySqlCommand("SELECT * FROM "+dbTableName,_connection);
           adapter.SelectCommand = command;
           adapter.Fill(table);
           List<Monster> b= new List<Monster>();
           for (int i = 0; i < table.Rows.Count; i++)
           {
              b.Add(new Monster(table.Rows[i].ItemArray));
           }
           return b;

        }

        public Monster get(int id)
        {
           DataTable table = new DataTable();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           MySqlCommand command = new MySqlCommand("SELECT * FROM "+dbTableName +" WHERE "+dbId+'='+id,_connection);
           adapter.SelectCommand = command;
           adapter.Fill(table);
           Monster b = new Monster(table.Rows[0].ItemArray);
              return b;
        }
        public Monster get(string name)
        {
           DataTable table = new DataTable();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           MySqlCommand command = new MySqlCommand("SELECT * FROM "+dbTableName +" WHERE "+dbName+"='"+name+"'",_connection);
           adapter.SelectCommand = command;
           adapter.Fill(table);
           Monster b = new Monster(table.Rows[0].ItemArray);
           return b;
        }

        public void Update(Monster monster,int id)
        {
           DataTable table = new DataTable();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           MySqlCommand command = new MySqlCommand("UPDATE "+dbTableName+" SET " + 
                                                   dbName + "='" + monster.Name +"', " + 
                                                   dbGenus + "='" + monster.Genus +"', " + 
                                                   dbDrop + "='" + monster.Drop +"'," + 
                                                   dbDander + "='" + monster.Danger +"' " +
                                                   " WHERE "+dbId+'='+ id,_connection);
           
           adapter.SelectCommand = command;
           adapter.Fill(table);

        }

        public void add(Monster monster)
        {
           DataTable table = new DataTable();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           MySqlCommand command = new MySqlCommand("INSERT INTO "+dbTableName+
                                                   " ("+dbName+", "+dbGenus+", "+dbDrop+", "+dbDander+
                                                   ") VALUES ( '"+monster.Name+"','"+monster.Genus+"','"+monster.Drop+"','"+monster.Danger+"')",_connection);
           
           adapter.SelectCommand = command;
           adapter.Fill(table);
        }

        public void delete(int id)
        {
           DataTable table = new DataTable();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           MySqlCommand command = new MySqlCommand("DELETE FROM " + dbTableName + " WHERE " + dbId + "=" + id,_connection);
           adapter.SelectCommand = command;
           adapter.Fill(table);
        }
        public void delete()
        {
           DataTable table = new DataTable();
           MySqlDataAdapter adapter = new MySqlDataAdapter();
           MySqlCommand command = new MySqlCommand("DELETE FROM " + dbTableName ,_connection);
           adapter.SelectCommand = command;
           adapter.Fill(table);
        }
    }
}