using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class ChooseHeroForm : Form
    {
        private CSVReader reader = new CSVReader("Overwatch.csv", Console.Out);
        private List<Hero> heroes = new List<Hero> { };
        private Random random = new Random();

        //Герой, которго выбрал игрок.
        private Hero playerHero = null;
        //Герой - бот
        private Hero botHero = null;

        public ChooseHeroForm()
        {
            heroes = reader.ConvertFileToHeroesList();
            InitializeComponent();
            FillComboBox();
        }

        /// <summary>
        /// Метод заполняет listBox значениями.
        /// </summary>
        private void FillComboBox()
        {
            this.comboBox1.Items.AddRange(heroes.ConvertAll(x => x.Name).ToArray());
            this.comboBox1.SelectionChangeCommitted += ComboBox1_SelectionChangeCommitted;
            this.comboBox1.DropDownHeight = 300;
        }

        /// <summary>
        /// Метод срабатывает при выборе отдного из предложенных элементов списка.
        /// После выбора элемнта на панеле отображаются параментры выбранного элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            playerHero = heroes[this.comboBox1.SelectedIndex];
            labelNameHero.Text = playerHero.Name;
            labelDamagePerSecond.Text = playerHero.DamagePerSecond.ToString();
            labelHeadshotDPS.Text = playerHero.HeadshotDPS.ToString();
            labelSingleShot.Text = playerHero.SingleShot.ToString();
            labelLife.Text = playerHero.Life.ToString();
            labelReload.Text = playerHero.Reload.ToString();
            panelHero.Visible = true;
        }

        /// <summary>
        /// Срабатывает при нажатии кнопки Accept.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (playerHero != null)
            {
                MessageBox.Show("You chose " + playerHero.ToString());
                botHero = ChooseBotHero();
                PlayingDesk playingDesk = new PlayingDesk(playerHero, botHero, "1");
                playingDesk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please, choose your hero");
            }
        }

        /// <summary>
        /// Метод определяет героя-бота.
        /// </summary>
        /// <returns>Hero bot</returns>
        private Hero ChooseBotHero()
        {
            if (playerHero == null)
                return null;
            Hero hero = heroes[random.Next(heroes.Count)];
            while (hero.Name.Equals(playerHero.Name))
                hero = heroes[random.Next(heroes.Count)];
            return hero;
        }
    }
}
