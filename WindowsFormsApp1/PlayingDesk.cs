using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ClassLibrary1;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class PlayingDesk : Form
    {
        private Hero playerHero;
        
        private Hero botHero;
        private Random random = new Random();

        public PlayingDesk(Hero playerHero, Hero botHero, string roundNumber)
        {
            InitializeComponent();
            this.playerHero = playerHero;
            this.botHero = botHero;
            labelRound.Text = "Round " + roundNumber;
            InitPanels();
        }

        /// <summary>
        /// Заполняет поля параметров игрока и бота.
        /// </summary>
        private void InitPanels()
        {
            // Заполнение полей игрока
            labelNameHero.Text = playerHero.Name;
            labelDamagePerSecond.Text = playerHero.DamagePerSecond.ToString();
            labelHeadshotDPS.Text = playerHero.HeadshotDPS.ToString();
            labelSingleShot.Text = playerHero.SingleShot.ToString();
            labelLife.Text = playerHero.Life.ToString();
            labelReload.Text = playerHero.Reload.ToString();

            //Заполнение полей бота
            labelNameHeroBot.Text = botHero.Name;
            labelDamagePerSecondBot.Text = botHero.DamagePerSecond.ToString();
            labelHeadshotDPSBot.Text = botHero.HeadshotDPS.ToString();
            labelSingleShotBot.Text = botHero.SingleShot.ToString();
            labelLifeBot.Text = botHero.Life.ToString();
            labelReloadBot.Text = botHero.Reload.ToString();
        }

        private void HeroWins(Hero hero)
        {
            try
            {
                if (File.Exists("playing-desk.xml"))
                    File.Delete("playing-desk.xml");
            } catch (Exception)
            {
                MessageBox.Show("Can't delete last saved round of finished game");
            }
            MessageBox.Show(hero.Name + " wins!!!");
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        /// <summary>
        /// Метод срабатывает при завершении раунда.
        /// Обновляет парамтры героев.
        /// </summary>
        private void FinishRound()
        {
            InitPanels();
            labelRound.Text = "Round " + (int.Parse(labelRound.Text.ToLower().Replace("round", "").Trim()) + 1).ToString();
            WriteXMLFile();
        }

        /// <summary>
        /// Записывает информацию текущего раунда в xml документ.
        /// </summary>
        private void WriteXMLFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("players");
            xmlDoc.AppendChild(rootNode);

            XmlAttribute attribute = xmlDoc.CreateAttribute("round");
            attribute.Value = labelRound.Text.ToLower().Replace("round", "").Trim();
            rootNode.Attributes.Append(attribute);

            rootNode.AppendChild(GeneratePlayerNode(playerHero, xmlDoc));
            rootNode.AppendChild(GeneratePlayerNode(botHero, xmlDoc));

            try
            {
                xmlDoc.Save("playing-desk.xml");
            } catch (XmlException)
            {
                MessageBox.Show("Cannot save round info");
            }
        }

        /// <summary>
        /// Генерирует node для xml документы.
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        private XmlNode GeneratePlayerNode(Hero hero, XmlDocument xmlDoc)
        {
            XmlNode playerNode = xmlDoc.CreateElement("player");
            XmlNode nameNode = xmlDoc.CreateElement("name");
            nameNode.InnerText = hero.Name;
            XmlNode damagePerSecondNode = xmlDoc.CreateElement("damagePerSecond");
            damagePerSecondNode.InnerText = hero.DamagePerSecond.ToString();
            XmlNode headshotDPSNode = xmlDoc.CreateElement("headshotDPS");
            headshotDPSNode.InnerText = hero.HeadshotDPS.ToString();
            XmlNode singleShotNode = xmlDoc.CreateElement("singleShot");
            singleShotNode.InnerText = hero.SingleShot.ToString();
            XmlNode lifeNode = xmlDoc.CreateElement("life");
            lifeNode.InnerText = hero.Life.ToString();
            XmlNode reloadNode = xmlDoc.CreateElement("reload");
            reloadNode.InnerText = hero.Reload.ToString();

            playerNode.AppendChild(nameNode);
            playerNode.AppendChild(damagePerSecondNode);
            playerNode.AppendChild(headshotDPSNode);
            playerNode.AppendChild(singleShotNode);
            playerNode.AppendChild(lifeNode);
            playerNode.AppendChild(reloadNode);

            return playerNode;
        }

        /// <summary>
        /// Выполняет ход компьютера.
        /// </summary>
        private void BotTurn()
        {
            double lostLife = playerHero.Life;
            if (random.Next(2) == 0)
            {
                if (playerHero.GetSimpleShot(botHero.DamagePerSecond))
                {
                    HeroWins(botHero);
                    return;
                }
                textConsole.AppendText(Environment.NewLine + botHero.Name + " makes simple shot!" + Environment.NewLine);
            } 
            else
            {
                if (playerHero.GetTargetShot(botHero.DamagePerSecond, botHero.HeadshotDPS))
                {
                    HeroWins(botHero);
                    return;
                }
                textConsole.AppendText(Environment.NewLine + botHero.Name + " makes target shot!" + Environment.NewLine);
            }
            lostLife -= playerHero.Life;
            textConsole.AppendText(playerHero.Name + " lost " + lostLife + " hp!" + Environment.NewLine);
            FinishRound();
        }

        /// <summary>
        /// Срабатывает при нажатии кнопки Simple attack.
        /// Наносит урон врагу и выводит сие сообщение в textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSimpleShot_Click(object sender, EventArgs e)
        {
            double lostLife = botHero.Life;
            if (botHero.GetSimpleShot(playerHero.DamagePerSecond))
            {
                HeroWins(playerHero);
                return;
            }
            lostLife -= botHero.Life;
            textConsole.AppendText(Environment.NewLine + playerHero.Name + " makes simple shot!" +
                                   Environment.NewLine + botHero.Name + " lost " + lostLife + " hp!" + Environment.NewLine);
            BotTurn();
        }

        /// <summary>
        /// Срабатывает при нажатии кнопки Target attack.
        /// Наносит урон врагу и выводит сие сообщение в textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTargetAttack_Click(object sender, EventArgs e)
        {
            double lostLife = botHero.Life;
            if (botHero.GetTargetShot(playerHero.DamagePerSecond, playerHero.HeadshotDPS))
            {
                HeroWins(playerHero);
                return;
            }
            lostLife -= botHero.Life;
            textConsole.AppendText(Environment.NewLine + playerHero.Name + " makes target shot!" +
                                   Environment.NewLine + botHero.Name + " lost " + lostLife + " hp!" + Environment.NewLine);
            BotTurn();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteXMLFile();
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}