namespace Yu.Client.WF
{
    public partial class TabForm : Form
    {
        public TabForm()
        {
            InitializeComponent();
            //SetButtonStyle(this);
            x = this.Width;
            y = this.Height;
            Yu.Client.WF.Helpers.ResizeHelper.SetTag(true, this);
        }
        private static Button LastButton = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnData_Click(BtnData, e);
        }

        #region 控件大小随窗体大小等比例缩放
        private void TabForm_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            //SetControls(newx, newy, this);
            Yu.Client.WF.Helpers.ResizeHelper.SetControls(true, newx, newy, this, specialControlNames: new string[] { nameof(panel1) });
        }
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        #endregion
        void SetButtonStyle(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                if (con.GetType().FullName == typeof(Button).FullName)
                {
                    var btn = (Button)con;
                    btn.BackColor = SystemColors.MenuHighlight;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.White;
                }
                if (con.Controls.Count > 0)
                {
                    SetButtonStyle(con);
                }
            }
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
