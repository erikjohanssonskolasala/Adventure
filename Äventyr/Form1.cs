namespace Äventyr
{
    public partial class Form1 : Form
    {
        bool altA = true;
        bool altB = false;
        bool altC = false;
        bool altD = false;
        bool altE = false;
        bool altF = false;
        bool altG = false;


        string scenA = "A";
        string scenB = "B";
        string scenC = "C";
        string scenD = "D";
        string scenE = "E";
        string scenF = "F";
        string scenG = "G";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = scenA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (altA == true)
            {
                altB = true;
                altA = false;
                textBox1.Text = scenB;

            }
            else if (altB == true)
            {
                altB = false;
                altD = true;
                textBox1.Text = scenD;
            }
            else if (altC == true)
            {
                altC = false;
                altF = true;
                textBox1.Text = scenF;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (altA == true)
            {
                altC = true;
                altA = false;
                textBox1.Text = scenC;

            }
            else if (altB == true)
            {
                altB = false;
                altE = true;
                textBox1.Text = scenE;
            }
            else if (altC == true)
            {
                altC = false;
                altG = true;
                textBox1.Text = scenG;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = scenA;
            altA = true;
        }
    }
}