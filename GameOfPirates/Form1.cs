namespace GameOfPirates
{
    public partial class Form1 : Form
    {
        public Gra Gra { get; set; }
        public Form1()
        {
            InitializeComponent();
            RandomOrFromFile.Init("Debug data\\RAND_NUM.txt", false, 0, false);
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

        private void button_next_Click(object sender, EventArgs e)
        {


           


            int test1 = RandomOrFromFile.Instance.Next(1, 100);
            double test2 = RandomOrFromFile.Instance.NextDouble();

            Print.czyscPlik();
            int K = int.Parse(textbox_num_of_boats_k.Text);
            int N = int.Parse(textBox_num_of_cols_n.Text);
            int M = int.Parse(textBox_num_of_rows_m.Text);
            MessageBox.Show("Tryb niedebugowania", "Informacja");
            Gra = new Gra();
            //Gra.InicjujDane(int.Parse(textbox_num_of_boats_k.Text));
            //Gra.DataInitialization1(readBoatsProfile(), checkBox_debug_mode, checkBox_test_1, K, N, M, checkBox_test_2);

            if (radioButton_custom_seed.Checked)
            {
                RandomOrFromFile.Reset();
                RandomOrFromFile.Init("Debug data\\RAND_NUM.txt", false, Int32.Parse(textBox_custom_seed.Text), true);
                Gra.DataInitialization1(readBoatsProfile(), checkBox_debug_mode, checkBox_test_1, K, N, M, checkBox_test_2, true, int.Parse(textBox_custom_seed.Text));

            }

            else
            {
                Gra.DataInitialization1(readBoatsProfile(), checkBox_debug_mode, checkBox_test_1, K, N, M, checkBox_test_2, false, int.Parse(textBox_custom_seed.Text));

            }


        }
        private int[,] readBoatsProfile()
        {

            int[,] profile = { { int.Parse(textBox_B_player_profile_1_1.Text), int.Parse(textBox_B_player_profile_1_2.Text),
                    int.Parse(textBox_B_player_profile_1_3.Text), int.Parse(textBox_B_player_profile_3_1.Text),
                    int.Parse(textBox_B_player_profile_3_2.Text), int.Parse(textBox_B_player_profile_3_3.Text) },
            {int.Parse(textBox_B_player_profile_2_1.Text), int.Parse(textBox_B_player_profile_2_2.Text),
                    int.Parse(textBox_B_player_profile_2_3.Text), int.Parse(textBox_B_player_profile_4_1.Text),
                    int.Parse(textBox_B_player_profile_4_2.Text), int.Parse(textBox_B_player_profile_4_3.Text) } };
            return profile;
        }
    }
}
