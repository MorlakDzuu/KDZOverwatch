using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class HeroTable : Form
    {
        private CSVReader reader = new CSVReader("Overwatch.csv", Console.Out);
        private string[][] data;
        private List<string> heroNames;
        private List<Hero> heroes;

        public HeroTable()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form_Load);
            this.data = reader.ReadFile();
            this.heroNames = GetHeroesNames();
            this.heroes = reader.ConvertFileToHeroesList();
        }

        private void Form_Load(Object sender, EventArgs e)
        {
            PopulateDataGridView();
            buttonSave.Click += new EventHandler(saveButton_Click);
        }

        /// <summary>
        /// Метод возвращает все имена героев.
        /// </summary>
        /// <returns></returns>
        private List<string> GetHeroesNames()
        {
            List<string> heroes = new List<string> { };
            for (int i = 0; i < data.Length; i++)
                heroes.Add(data[i][0]);
            return heroes;
        }

        /// <summary>
        /// Срабатывет при нажатии кнопки save.
        /// Перезаписывает файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            reader.RewriteFile(data);
        }

        /// <summary>
        /// Настраивает таблицу.
        /// </summary>
        private void PopulateDataGridView()
        {
            dataGridView1.DataSource = heroes;
            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            foreach (DataGridViewTextBoxColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 80;
            }

            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
        }

        /// <summary>
        /// Метод вызывается после редактирования ячейки и валидирует входные данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null)
            {
                string value = null;
                try
                {
                    value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                } catch (NullReferenceException)
                {
                    MessageBox.Show("Value can't be null");
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = data[e.RowIndex][e.ColumnIndex];
                }
                if (value != null)
                {
                    // В зависимости от заголовка таблицы проверяет данные, которые ввел пользователь в ячейку
                    switch (dataGridView1.Columns[e.ColumnIndex].Name.Trim().Replace("DataGridViewTextBoxColumn", ""))
                    {
                        case "name":
                            if (heroNames.Contains(value.ToString().Trim()) || (value.ToString().Trim() == String.Empty))
                            {
                                MessageBox.Show("This name exists or value is empty");
                                dataGridView1[e.ColumnIndex, e.RowIndex].Value = data[e.RowIndex][e.ColumnIndex];
                            }
                            else
                                data[e.RowIndex][e.ColumnIndex] = value.ToString().Trim();
                            break;
                        case "damagePerSecond":
                            ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                                "Invalid value of Damage per second, it should be in range 0..525", 525);
                            break;
                        case "headshotDPS":
                            ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                                "Invalid value of Headshot DPS, it should be in range 0..1050", 1050);
                            break;
                        case "singleShot":
                            ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                                "Invalid value of Single shot, it should be in range 0..300", 300);
                            break;
                        case "life":
                            ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                                "Invalid value of Life, it should be in range 0..800", 800);
                            break;
                        case "reload":
                            if (value.ToString() == "infinity")
                                data[e.RowIndex][e.ColumnIndex] = "infinity";
                            else
                                ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                                               "Invalid value of Reload, it should be in range 0..200 or 'infinity'", 200);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Метод проверяет правильность входных данных таблицы.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="columnIndex"></param>
        /// <param name="rowIndex"></param>
        /// <param name="message"></param>
        /// <param name="upperBound"></param>
        private void ChangeCellData(string value, int columnIndex, int rowIndex, string message, int upperBound)
        {
            double n;
            if (double.TryParse(value, out n) && (n >= 0) && (n <= upperBound))
            {
                data[rowIndex][columnIndex] = value;
            }
            else
            {
                MessageBox.Show(message);
                dataGridView1[columnIndex, rowIndex].Value = data[rowIndex][columnIndex];
            }
        }

        /// <summary>
        /// Отфильтровывает спсиок по заданным параметрам.
        /// </summary>
        /// <param name="dpsFrom"></param>
        /// <param name="dpsTo"></param>
        /// <param name="lifeFrom"></param>
        /// <param name="lifeTo"></param>
        /// <param name="headshotFrom"></param>
        /// <param name="headshotTo"></param>
        /// <returns></returns>
        private List<Hero> GetFilteredHeroList(double dpsFrom, double dpsTo, double lifeFrom, double lifeTo, double headshotFrom,
                                               double headshotTo)
        {
            List<Hero> filtereHeroList = new List<Hero> { };
            List<Hero> heroes = reader.ConvertFileToHeroesList();
            foreach (Hero hero in heroes)
            {
                if ((hero.DamagePerSecond >= dpsFrom) && (hero.DamagePerSecond <= dpsTo) &&
                    (hero.Life >= lifeFrom) && (hero.Life <= lifeTo) &&
                    (hero.HeadshotDPS >= headshotFrom) && (hero.HeadshotDPS <= headshotTo))
                    filtereHeroList.Add(hero);
            }
            return filtereHeroList;
        }

        /// <summary>
        /// Срабатывет при нажатии кнопки Apply.
        /// Считывает границы значений полей фильтра и выводит отфильтрованный список в качестве таблицы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            double dpsFrom;
            double dpsTo;
            double lifeFrom;
            double lifeTo;
            double headshotFrom;
            double headshotTo;
            try
            {
                dpsFrom = double.Parse(dpsTextBoxFrom.Text);
                dpsTo = double.Parse(dpsTextBoxTo.Text);
                lifeFrom = double.Parse(lifeTextBoxFrom.Text);
                lifeTo = double.Parse(lifeTextBoxTo.Text);
                headshotFrom = double.Parse(headshotTextBoxFrom.Text);
                headshotTo= double.Parse(headshotTextBoxTo.Text);
            } catch (Exception)
            {
                MessageBox.Show("Invalid value");
                return;
            }
            List<Hero> filteredHeroes = GetFilteredHeroList(dpsFrom, dpsTo, lifeFrom, lifeTo, headshotFrom, headshotTo);
            if (this.heroes.Count != filteredHeroes.Count)
            {
                dataGridView1.DataSource = filteredHeroes;
                MessageBox.Show("You can't edit filtered table!");
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.ReadOnly = true;
                }
            }
            
        }

        /// <summary>
        /// Отображает таблицу исходного файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturnTable_Click(object sender, EventArgs e)
        {
            this.heroes = reader.ConvertFileToHeroesList();
            dataGridView1.DataSource = this.heroes;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = false;
            }
        }

        /// <summary>
        /// Срабатывает при нажатии кнопки Satrt.
        /// Создает форму выбора персонажа, отображает ее и срывает текущую.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
