namespace GameOfPirates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RandomOrFromFile.Init("Debug data\\RAND_NUM.txt", true);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1;

            chart1.Series[0].Points.AddXY(0.1, 0.2);
            chart1.Series[0].Points.AddXY(0.4, 0.6);
            chart1.Series[0].Points.AddXY(0.9, 0.95);

            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 1;

            chart2.Series[0].Points.AddXY(0.1, 0.2);
            chart2.Series[0].Points.AddXY(0.4, 0.6);
            chart2.Series[0].Points.AddXY(0.9, 0.95);

            chart3.ChartAreas[0].AxisX.Minimum = 0;
            chart3.ChartAreas[0].AxisY.Minimum = 0;
            chart3.ChartAreas[0].AxisY.Maximum = 1;

            chart3.Series[0].Points.AddXY(0.1, 0.2);
            chart3.Series[0].Points.AddXY(0.4, 0.6);
            chart3.Series[0].Points.AddXY(0.9, 0.95);

            chart4.ChartAreas[0].AxisX.Minimum = 0;
            chart4.ChartAreas[0].AxisY.Minimum = 0;
            chart4.ChartAreas[0].AxisY.Maximum = 1;

            chart4.Series[0].Points.AddXY(0.1, 0.2);
            chart4.Series[0].Points.AddXY(0.4, 0.6);
            chart4.Series[0].Points.AddXY(0.9, 0.95);
        }
    }
}
