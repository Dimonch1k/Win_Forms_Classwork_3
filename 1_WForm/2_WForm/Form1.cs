namespace _2_WForm
{
    public partial class Form1 : Form
    {

        private Dictionary<string, DateTime> dictionary = new Dictionary<string, DateTime>();
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 &&
                textBox2.Text.Length != 0 &&
                textBox3.Text.Length != 0 &&
                textBox4.Text.Length != 0)
            {
                button1.Enabled = true;
                return;
            }
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{listBox1.Items.Count + 1}. {textBox1.Text} ({textBox2.Text} {textBox3.Text} {textBox4.Text})");

            var timeNotify = DateTime.Parse($"{textBox2.Text}:{textBox3.Text}:{textBox4.Text}");
            //var timeNow = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"));

            dictionary.Add(textBox1.Text, timeNotify);

            // Clear textBoxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var timeNow = DateTime.Parse(DateTime.Now.ToString("HH:mm:ss"));
            foreach (var item in dictionary.Keys)
            {
                if (dictionary[item].Equals(timeNow))
                {
                    MessageBox.Show(item);
                }
            }
        }












        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}