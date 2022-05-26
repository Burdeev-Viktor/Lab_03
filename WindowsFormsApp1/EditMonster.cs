using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditMonster : Form
    {
        private List<Monster> monsters;
        private static int id;
        public EditMonster(List<Monster> monsters)
        {
            this.monsters = monsters;
            InitializeComponent();
            comboBox1.Items.AddRange(new string[]{"Животное","Инсектоид","Драконид","Гибрид","Призрак","Реликт","Проклятье","Огр","Дух Стихии","Трупоед","Вампир","Другие"});
            comboBox2.Items.AddRange(new string[] {"Легко","Средне","Сложно","Ни один ведьмак не умер в собственной кровати" });
            for (int i = 0; i < monsters.Count; i++)
            {
                comboBox3.Items.Add(monsters[i].Name);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < monsters.Count; i++)
            {
                if (monsters[i].Name == comboBox3.SelectedItem.ToString())
                {
                    id = monsters[i].Id;
                    textBox1.Text = monsters[i].Name;
                    comboBox1.SelectedItem = monsters[i].Genus;
                    textBox2.Text = monsters[i].Drop;
                    comboBox2.SelectedItem = monsters[i].Danger;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "" || comboBox1.SelectedItem == null || textBox2.Text == "" || comboBox2.SelectedItem == null )
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            
            DatabaseHendler databaseHendler = new DatabaseHendler();
            databaseHendler.openDatabase();
            databaseHendler.Update(new Monster(textBox1.Text, comboBox1.SelectedItem.ToString(), textBox2.Text,
                comboBox2.SelectedItem.ToString()),id);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}