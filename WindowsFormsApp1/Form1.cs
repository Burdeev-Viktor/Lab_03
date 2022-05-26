using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static List<Monster> _monsters;
        public Form1()
        {

            InitializeComponent();
            dataGridView1.DataSource = dataRefresh();
            
        }
        
        private void добавитьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMonster f = new AddMonster(_monsters);
            f.Show();
            
        }

        private static DataTable dataRefresh()
        {
            DatabaseHendler databaseHendler = new DatabaseHendler();
            databaseHendler.openDatabase();
            _monsters = databaseHendler.get();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Имя", typeof(string));
            dataTable.Columns.Add("Род", typeof(string));
            dataTable.Columns.Add("Дроп", typeof(string));
            dataTable.Columns.Add("Опастность", typeof(string));
            for (int i = 0; i < _monsters.Count; i++)
            {
                dataTable.Rows.Add(_monsters[i].Name, _monsters[i].Genus, _monsters[i].Drop, _monsters[i].Danger);
            }

            return dataTable;
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataRefresh();
        }

        private void изменитьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMonster f = new EditMonster(_monsters);
            f.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMonster f = new DeleteMonster(_monsters);
            f.Show();
        }

        private void получитьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetMonster f = new GetMonster(_monsters);
            f.Show();
        }
    }
}