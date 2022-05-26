using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class GetMonster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Danger = new System.Windows.Forms.Label();
            this.label_Drop = new System.Windows.Forms.Label();
            this.label_Genus = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(98, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Danger);
            this.groupBox1.Controls.Add(this.label_Drop);
            this.groupBox1.Controls.Add(this.label_Genus);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат:";
            // 
            // label_Danger
            // 
            this.label_Danger.Location = new System.Drawing.Point(103, 99);
            this.label_Danger.Name = "label_Danger";
            this.label_Danger.Size = new System.Drawing.Size(144, 43);
            this.label_Danger.TabIndex = 8;
            // 
            // label_Drop
            // 
            this.label_Drop.Location = new System.Drawing.Point(103, 76);
            this.label_Drop.Name = "label_Drop";
            this.label_Drop.Size = new System.Drawing.Size(144, 13);
            this.label_Drop.TabIndex = 7;
            // 
            // label_Genus
            // 
            this.label_Genus.Location = new System.Drawing.Point(103, 51);
            this.label_Genus.Name = "label_Genus";
            this.label_Genus.Size = new System.Drawing.Size(144, 19);
            this.label_Genus.TabIndex = 5;
            // 
            // label_Name
            // 
            this.label_Name.Location = new System.Drawing.Point(103, 27);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(144, 14);
            this.label_Name.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Опастность:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Дроп:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Род:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GetMonster";
            this.Text = "GetMonster";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Genus;
        private System.Windows.Forms.Label label_Drop;
        private System.Windows.Forms.Label label_Danger;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        #endregion
    }
}