using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GetMonster : Form
    {
        private List<Monster> monsters;
        public GetMonster(List<Monster> monsters)
        {
            this.monsters = monsters;
            InitializeComponent();
            for (int i = 0; i < monsters.Count; i++)
            {
                comboBox1.Items.Add(monsters[i].Name);
                comboBox2.Items.Add(monsters[i].Id);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseHendler databaseHendler = new DatabaseHendler();
            databaseHendler.openDatabase();
            Monster monster = databaseHendler.get(comboBox1.SelectedItem.ToString());
            label_Name.Text = monster.Name;
            label_Genus.Text = monster.Genus;
            label_Drop.Text = monster.Drop;
            label_Danger.Text = monster.Danger;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseHendler databaseHendler = new DatabaseHendler();
            databaseHendler.openDatabase();
            Monster monster = databaseHendler.get((int)comboBox2.SelectedItem);
            label_Name.Text = monster.Name;
            label_Genus.Text = monster.Genus;
            label_Drop.Text = monster.Drop;
            label_Danger.Text = monster.Danger;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}