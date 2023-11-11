namespace WinFormsApp1__listbox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            do
            {
                listBox1.Items.Add(x);
                x++;
            }
            while (x <= 10);
        }
    }
}