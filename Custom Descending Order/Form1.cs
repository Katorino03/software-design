using System.Globalization;

namespace Custom_Descending_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Sorting
        {
            public static int[] ProceduralSort(int[] numbers)
            {
                int n = numbers.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (numbers[j] < numbers[j + 1])
                        {
                            int temp = numbers[j];
                            numbers[j] = numbers[j + 1];
                            numbers[j + 1] = temp;
                        }
                    }
                }
                return numbers;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 75, 70, 80, 90, 85 };
            int[] sortedNumbers = Sorting.ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}