namespace OOP4Belovol
{
    public partial class Form1 : Form
    {
        private int[,] array;
        private int currentRow = 0;
        private int currentColumn = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnDisplayArray_Click(object sender, EventArgs e)
        {
            try
            {
                array = GetInputArray();

                DisplayArray();

                DisplayBottomRightElement();
                DisplayTopLeftElement();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка");
            }
        }

        private int[,] GetInputArray()
        {
            string[] values1 = textBox1.Text.Split(' ');
            string[] values2 = textBox2.Text.Split(' ');
            string[] values3 = textBox3.Text.Split(' ');
            string[] values4 = textBox4.Text.Split(' ');

            if (values1.Length != 4 || values2.Length != 4 || values3.Length != 4 || values4.Length != 4)
            {
                throw new ArgumentException("Кожен рядок масиву повинен містити 4 значення.");
            }

            int[,] inputArray = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                inputArray[0, i] = int.Parse(values1[i]);
                inputArray[1, i] = int.Parse(values2[i]);
                inputArray[2, i] = int.Parse(values3[i]);
                inputArray[3, i] = int.Parse(values4[i]);
            }

            return inputArray;
        }

        private void DisplayArray()
        {
            dataGridViewArray.RowCount = array.GetLength(0);
            dataGridViewArray.ColumnCount = array.GetLength(1);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridViewArray.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private void DisplayBottomRightElement()
        {
            int rowCount = array.GetLength(0);
            int columnCount = array.GetLength(1);
            int bottomRightElement = array[rowCount - 1, columnCount - 1];
            labelBottomRight.Text = $"Елемент у правому нижньому куті: {bottomRightElement}";
        }

        private void DisplayTopLeftElement()
        {
            int topLeftElement = array[0, 0];
            labelTopLeft.Text = $"Елемент у лівому верхньому куті: {topLeftElement}";
        }

        private void btnCalculateArray1_Click(object sender, EventArgs e)
        {
            string[] inputArray = textBoxArray1.Text.Split(' ');
            double[] array = Array.ConvertAll(inputArray, double.Parse);

            double minElement = array.Min();

            double positiveProduct = array.Where(x => x > 0).Aggregate(1.0, (acc, val) => acc * val);

            double sumBeforeMin = array.Take(Array.IndexOf(array, minElement)).Sum();

            double[] evenElements = array.Where((x, i) => i % 2 != 0).OrderBy(x => x).ToArray();
            double[] oddElements = array.Where((x, i) => i % 2 == 0).OrderBy(x => x).ToArray();

            labelResultArray1.Text = $"Добуток додатних елементів: {positiveProduct}\n" +
                          $"Сума елементів до мінімального: {sumBeforeMin}\n" +
                          $"Парні елементи: {string.Join(", ", evenElements)}\n" +
                          $"Непарні елементи: {string.Join(", ", oddElements)}";
        }
    }
}