using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DeleteMonster : Form
    {
        private List<Monster> monsters;
        public DeleteMonster(List<Monster> monsters)
        {
            this.monsters = monsters;
            InitializeComponent();
            comboBox.Items.Add("Всё");
            for (int i = 0; i < monsters.Count; i++)
            {
                comboBox.Items.Add(monsters[i].Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите монстра");
                return;
            }

            DatabaseHendler databaseHendler = new DatabaseHendler();
            databaseHendler.openDatabase();
            if (comboBox.SelectedItem.ToString() == "Всё")
            {
                databaseHendler.delete();
                return;
            }
            else
            {
                for (int i = 0; i < monsters.Count; i++)
                {
                    if (comboBox.SelectedItem.ToString() == monsters[i].Name)
                    {
                        databaseHendler.delete(monsters[i].Id);
                        
                    }
                }
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}