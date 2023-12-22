namespace Yu.Client.WF
{
    public partial class TabForm : Form
    {
        public TabForm()
        {
            InitializeComponent();
        }
        private static Button LastButton = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnData_Click(BtnData, e);
        }

        private void BtnData_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new DataControl { Dock = DockStyle.Fill });
            LastButton = (Button)sender;
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MapControl { Dock = DockStyle.Fill });
            LastButton = (Button)sender;
        }

        private void BtnBle_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new BleControl { Dock = DockStyle.Fill });
            LastButton = (Button)sender;
        }

        private void BtnMedia_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new MediaControl { Dock = DockStyle.Fill });
            LastButton = (Button)sender;
        }

        private void BtnSocket_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new SocketControl { Dock = DockStyle.Fill });
            LastButton = (Button)sender;
        }

        private void BtnOther_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就这些了");
            LastButton.Focus();
        }
    }
}
