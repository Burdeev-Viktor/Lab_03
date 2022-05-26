using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddMonster : Form
    {
        private List<Monster> monsters;
        public AddMonster(List<Monster> monsters)
        {
            this.monsters = monsters;
            InitializeComponent();
            comboBox1.Items.AddRange(new string[]{"Животное","Инсектоид","Драконид","Гибрид","Призрак","Реликт","Проклятье","Огр","Дух Стихии","Трупоед","Вампир","Другие"});
            comboBox2.Items.AddRange(new string[] {"Легко","Средне","Сложно","Ни один ведьмак не умер в собственной кровати" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "" || comboBox1.SelectedItem == null || textBox2.Text == "" || comboBox2.SelectedItem == null )
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            for (int i = 0; i < monsters.Count; i++)
            {
                if (monsters[i].Name == textBox1.Text)
                {
                    MessageBox.Show("Такое имя уже используется");
                    return;
                }
            }

            DatabaseHendler databaseHendler = new DatabaseHendler();
            databaseHendler.openDatabase();
            databaseHendler.add(new Monster(textBox1.Text, comboBox1.SelectedItem.ToString(), textBox2.Text,
                comboBox2.SelectedItem.ToString()));
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}