using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary1;
using System.Collections;
public class Form1 : Form
{
    private Panel buttonPanel = new Panel();
    private DataGridView dataGridView = new DataGridView();
    private Button addNewRowButton = new Button();
    private Button deleteRowButton = new Button();
    private Button saveButton = new Button();
    private CSVReader reader = new CSVReader("Overwatch.csv", Console.Out);
    private string[][] data;
    private List<string> heroes;

    public Form1()
    {
        this.Load += new EventHandler(Form1_Load);
        this.data = reader.ReadFile();
        heroes = GetHeroesNames();
    }

    private void Form1_Load(Object sender, EventArgs e)
    {
        SetupLayout();
        SetupDataGridView();
        PopulateDataGridView(this.data);
    }

    /// <summary>
    /// Метод вызывается после редактирования ячейки и валидирует входные данные.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        string value = dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
        if (e != null)
        {
            if (value != null)
            {
                switch (dataGridView.Columns[e.ColumnIndex].Name.Trim())
                {
                    case "Heroes":
                        if (heroes.Contains(value.ToString().Trim()) || (value.ToString().Trim() == String.Empty))
                        {
                            MessageBox.Show("This name exists or value is empty");
                            dataGridView[e.ColumnIndex, e.RowIndex].Value = data[e.RowIndex][e.ColumnIndex];
                        }
                        else
                            data[e.RowIndex][e.ColumnIndex] = value.ToString().Trim();
                        break;
                    case "Damage per second":
                        ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                            "Invalid value of Damage per second, it should be in range 0..525", 525);
                        break;
                    case "Headshot DPS":
                        ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                            "Invalid value of Headshot DPS, it should be in range 0..1050", 1050);
                        break;
                    case "Single shot":
                        ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                            "Invalid value of Single shot, it should be in range 0..300", 300);
                        break;
                    case "Life":
                        ChangeCellData(value.ToString(), e.ColumnIndex, e.RowIndex,
                            "Invalid value of Life, it should be in range 0..600", 600);
                        break;
                    case "Reload":
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
            dataGridView[columnIndex, rowIndex].Value = data[rowIndex][columnIndex];
        }
    }

    private void addNewRowButton_Click(object sender, EventArgs e)
    {
        this.dataGridView.Rows.Add();
    }

    private void deleteRowButton_Click(object sender, EventArgs e)
    {
        if (this.dataGridView.SelectedRows.Count > 0 &&
            this.dataGridView.SelectedRows[0].Index !=
            this.dataGridView.Rows.Count - 1)
        {
            this.dataGridView.Rows.RemoveAt(
                this.dataGridView.SelectedRows[0].Index);
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        reader.RewriteFile(data);
    }

    private void SetupLayout()
    {
        this.Size = new Size(600, 500);

        addNewRowButton.Text = "Add Row";
        addNewRowButton.Location = new Point(10, 10);
        addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

        deleteRowButton.Text = "Delete Row";
        deleteRowButton.Location = new Point(100, 10);
        deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

        saveButton.Text = "Save data";
        saveButton.Location = new Point(200, 10);
        saveButton.Click += new EventHandler(saveButton_Click);

        CheckBox checkBox = new CheckBox();
        checkBox.Appearance = Appearance.Button;
        checkBox.AutoCheck = false;
        checkBox.Click += CheckBox_Click;
        checkBox.Location = new Point(300, 10);
        checkBox.Size = new Size(20, 20);

        buttonPanel.Controls.Add(addNewRowButton);
        buttonPanel.Controls.Add(deleteRowButton);
        buttonPanel.Controls.Add(saveButton);
        buttonPanel.Controls.Add(checkBox);
        buttonPanel.Height = 50;
        buttonPanel.Dock = DockStyle.Bottom;

        this.Controls.Add(this.buttonPanel);
    }

    private void CheckBox_Click(object sender, EventArgs e)
    {
        /*int n = 0;
        for (int i = 0; i < this.dataGridView.Rows.Count - 1; i++)
        {
            this.dataGridView.Rows.RemoveAt(i);
            n = i;
        }*/
        // Это костыль, но другого способа удолить все строки сразу я не нашел
        while (this.dataGridView.Rows.Count > 1)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index != this.dataGridView.Rows.Count - 1)
                    this.dataGridView.Rows.RemoveAt(row.Index);
            }
        }
        Hero[] heroes = reader.ConvertFileToHeroesList().ToArray();
        Array.Sort(heroes);
        foreach (Hero hero in heroes)
        {
            dataGridView.Rows.Add(ConvertHeroToStringArray(hero));
        }
    }

    private string[] ConvertHeroToStringArray(Hero hero)
    {
        string[] strings = new string[6];
        strings[0] = hero.Name;
        strings[1] = hero.DamagePerSecond.ToString();
        strings[2] = hero.HeadshotDPS.ToString();
        strings[3] = hero.SingleShot.ToString();
        strings[4] = hero.Life.ToString();
        strings[5] = hero.Reload.ToString();
        return strings;
    }

    private void SetupDataGridView()
    {
        string[] headers = reader.GetHeaders();

        this.Controls.Add(dataGridView);

        dataGridView.ColumnCount = 6;

        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        dataGridView.ColumnHeadersDefaultCellStyle.Font =
            new Font(dataGridView.Font, FontStyle.Bold);

        dataGridView.Name = "heroesDataGridView";
        dataGridView.Location = new Point(8, 8);
        dataGridView.Size = new Size(500, 250);
        dataGridView.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        dataGridView.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.Single;
        dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        dataGridView.GridColor = Color.Black;
        dataGridView.RowHeadersVisible = false;

        for (int i = 0; i < headers.Length; i++)
            dataGridView.Columns[i].Name = headers[i];

        dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
        dataGridView.MultiSelect = false;
        dataGridView.Dock = DockStyle.Fill;

        this.dataGridView.CellEndEdit += dataGridView_CellEndEdit;
    }
    
    private void PopulateDataGridView(string[][] data)
    {
        for (int i = 0; i < data.Length; i++)
            dataGridView.Rows.Add(data[i]);
    }

    private void InitializeComponent()
    {
    
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Name = "Form1";
            this.ResumeLayout(false);
    }
}