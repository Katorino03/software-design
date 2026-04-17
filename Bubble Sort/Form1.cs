namespace Bubble_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] ProceduralSort(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 75, 70, 80, 90, 85 };
            int[] sortedNumbers = ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}