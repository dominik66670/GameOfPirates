namespace GameOfPirates
{
    public partial class Form1 : Form
    {
        public Gra Gra { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (checkBox_debug_mode.Checked)
            {
                MessageBox.Show("Tryb debugowania", "Informacja");
                
                Gra = new Gra();
                Gra.LadujDaneDebugowania(int.Parse(textbox_num_of_boats_k.Text));
                Print.czyscPlik();
                Print.print1(Gra);
                Print.print2(Gra);
                Print.print3(Gra);
                Print.print11(Gra);
                Print.print12(Gra);
                Print.print13(Gra);
            }

            else
            {
                MessageBox.Show("Tryb niedebugowania", "Informacja");
                Gra = new Gra();
                Gra.InicjujDane(int.Parse(textbox_num_of_boats_k.Text));
                Print.czyscPlik();
                Print.print1(Gra);
                Print.print2(Gra);
                Print.print3(Gra);
                Print.print11(Gra);
                Print.print12(Gra);
                Print.print13(Gra);
            }
        }
    }
}
