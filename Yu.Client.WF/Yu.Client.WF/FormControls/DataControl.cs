namespace Yu.Client.WF
{
    public partial class DataControl : UserControl
    {
        public DataControl()
        {
            InitializeComponent();
            x = this.Width;
            y = this.Height;
            Yu.Client.WF.Helpers.ResizeHelper.SetTag(true, this);
        }

        #region 控件大小随窗体大小等比例缩放
        private void DataControl_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            Yu.Client.WF.Helpers.ResizeHelper.SetControls(false, newx, newy, this, specialControlNames: new string[] { nameof(panel1) });
        }
        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度
        #endregion

        private async void DataControl_Load(object sender, EventArgs e)
        {
            await Task.Run(async () => { await Task.Delay(100); FillData(); });
        }

        private void FillData()
        {
            Invoke(new MethodInvoker(delegate ()
            {
                dataGridView1.Rows.Clear();
                var random = new Random();
                for (int i = 0; i < 100; i++)
                {
                    if (random.Next() % 2 == 0)
                    {
                        dataGridView1.Rows.Add(i + 1, random.Next(100, 200), random.Next(800, 1000), random.Next(80, 1000), "出售", $"用户{i % 3}", DateTime.Now.AddDays(-random.Next(1, 10)), "已取消", DateTime.Now.AddSeconds(-random.Next(1, 10)), "删除 | 编辑");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(i + 1, random.Next(100, 200), random.Next(800, 1000), random.Next(80, 1000), "求购", $"用户{i % 5}", DateTime.Now.AddDays(-random.Next(1, 10)), "进行中", DateTime.Now.AddSeconds(-random.Next(1, 10)), "删除 | 编辑");
                    }
                }
                // 将按钮列添加到DataGridView
                dataGridView1.Columns.Add(new DataGridViewButtonColumn
                {
                    HeaderText = "隐藏",
                    Text = "隐藏",
                    UseColumnTextForButtonValue = true
                });

                #region DataTable
                //var dt = new DataTable();
                //var dc = new DataColumn();
                //dc.ReadOnly = true;

                //dt.Columns.Add("ID", typeof(int));
                //dt.Columns.Add("MinCount");
                //dt.Columns.Add("MaxCount");
                //dt.Columns.Add("Surplus");
                //dt.Columns.Add("OrderType");
                //dt.Columns.Add("OrderUser");
                //dt.Columns.Add("AddTime");
                //dt.Columns.Add("IsFinish");
                //dt.Columns.Add("FinishTime");
                //var dr = dt.NewRow();
                //dr["Id"] = 123;
                //dr["MinCount"] = 100;
                //dr["MaxCount"] = 1000;
                //dr["Surplus"] = 200;
                //dr["OrderType"] = "出售";
                //dr["OrderUser"] = "张三";

                //dr["AddTime"] = DateTime.Now.AddHours(-5);
                //dr["IsFinish"] = "已取消";
                //dr["FinishTime"] = DateTime.Now;

                //dr["Opera"] = 123;
                //dr["ToHide"] = 123;
                //dt.Rows.Add(dr);
                //dataGridView1.DataSource = dt; 
                #endregion

            }));
        }


        private void BtnQuery_Click(object sender, EventArgs e)
        {

        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCount.Text, out _))
            {
                txtCount.Text = string.Empty;
            }
        }
        int mouseX = 0;
        int mouseY = 0;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "ToOpera")
                {
                    mouseX = e.X;
                    mouseY = e.Y;
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                switch (dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "ToOpera":
                        var rect = this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);//单元格矩形
                        if (0 < mouseX && mouseX < rect.Width / 3)
                        {
                            MessageBox.Show($"删除 {e.RowIndex}行 {e.ColumnIndex}列");
                        }
                        else if (rect.Width / 3 < mouseX && mouseX < rect.Width / 3 * 2)
                        {
                            MessageBox.Show($"编辑 {e.RowIndex}行 {e.ColumnIndex}列");
                        }
                        else if (rect.Width / 3 * 2 < mouseX && mouseX < rect.Width)
                        {
                            MessageBox.Show($"隐藏 {e.RowIndex}行 {e.ColumnIndex}列");
                        }
                        break;
                }
            }
        }
    }
}
