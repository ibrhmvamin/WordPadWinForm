using System.Drawing.Text;

namespace WordPadWinForm
{
    public partial class Form1 : Form
    {
        public InstalledFontCollection fontArr = new InstalledFontCollection() { };
        public List<int> sizeInt = new() { };
        public List<Color> colors = new() { };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var font in fontArr.Families)
            {
                fontcb.Items.Add(font.Name);
            }

            //fontcb.SelectedIndex = 231;

            for (int i = 8; i < 50; i++)
            {
                sizeInt.Add(i);
            }

            sizecb.DataSource = sizeInt;
            sizecb.SelectedIndex = 8;

            foreach (Color c in new ColorConverter().GetStandardValues())
            {
                colors.Add(c);
            }

            foreach (var c in colors)
            {
                colorcb.Items.Add(c);
            }
            colorcb.SelectedItem = Color.Black;
        }

        private void fontcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = fontcb.SelectedIndex;
            FontFamily font = fontArr.Families[index];
            richTextBox1.Font = new Font(font, richTextBox1.Font.Size, richTextBox1.Font.Style);
        }

        private void sizecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = sizecb.SelectedIndex;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, index, richTextBox1.Font.Style);
        }

        private void colorcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = colorcb.SelectedIndex;
            FontFamily font = fontArr.Families[index];
            richTextBox1.Font = new Font(font, index, colorcb.Font.Style);
            richTextBox1.ForeColor = colors[index];
        }

        private void loadtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadtb_Click(object sender, EventArgs e)
        {
            if (loadtb.Text == "Enter name and load file." || loadtb.Text == null)
            {
                loadtb.Text = "";
            }
        }

        private void savetb_Click(object sender, EventArgs e)
        {
            if (savetb.Text == "Tap enter name and save." || savetb.Text == null)
            {
                savetb.Text = "";
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(loadtb.Text)) 
            {
                MessageBox.Show("This file does not exists");
            }
            else
            {
                string text=File.ReadAllText(loadtb.Text);
                richTextBox1.Text = text;
                MessageBox.Show($"Text loaded from {loadtb.Text} file");
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(savetb.Text, richTextBox1.Text);
            MessageBox.Show($"Text saved to {savetb.Text} file successfly");
            savetb.Text = " ";
        }
    }
}

