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
    public partial class Menu : Form
    {
        private Button buttonStartGame;
        private Button buttonViewTable;
        private Button buttonContinue;

        public Menu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonViewTable = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.SystemColors.Info;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.Location = new System.Drawing.Point(240, 110);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(323, 83);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start game";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonViewTable
            // 
            this.buttonViewTable.BackColor = System.Drawing.SystemColors.Info;
            this.buttonViewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewTable.Location = new System.Drawing.Point(240, 222);
            this.buttonViewTable.Name = "buttonViewTable";
            this.buttonViewTable.Size = new System.Drawing.Size(323, 83);
            this.buttonViewTable.TabIndex = 1;
            this.buttonViewTable.Text = "View table";
            this.buttonViewTable.UseVisualStyleBackColor = false;
            this.buttonViewTable.Click += new System.EventHandler(this.buttonViewTable_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.SystemColors.Info;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(240, 330);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(323, 83);
            this.buttonContinue.TabIndex = 2;
            this.buttonContinue.Text = "Continue game";
            this.buttonContinue.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.BackgroundMenu;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonViewTable);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            ChooseHeroForm chooseHeroForm = new ChooseHeroForm();
            chooseHeroForm.Show();
            this.Hide();
        }

        private void buttonViewTable_Click(object sender, EventArgs e)
        {
            HeroTable heroTable = new HeroTable();
            heroTable.Show();
            this.Hide();
        }
    }
}
