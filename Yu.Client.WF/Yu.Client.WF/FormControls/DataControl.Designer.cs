namespace Yu.Client.WF
{
    partial class DataControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            CkbCancel = new CheckBox();
            CbbFinish = new ComboBox();
            txtCount = new TextBox();
            BtnQuery = new Button();
            Id = new DataGridViewTextBoxColumn();
            MinCount = new DataGridViewTextBoxColumn();
            MaxCount = new DataGridViewTextBoxColumn();
            Surplus = new DataGridViewTextBoxColumn();
            OrderType = new DataGridViewTextBoxColumn();
            OrderUser = new DataGridViewTextBoxColumn();
            AddTime = new DataGridViewTextBoxColumn();
            IsFinish = new DataGridViewTextBoxColumn();
            FinishTime = new DataGridViewTextBoxColumn();
            ToOpera = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, MinCount, MaxCount, Surplus, OrderType, OrderUser, AddTime, IsFinish, FinishTime, ToOpera });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(964, 359);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 359);
            panel1.TabIndex = 2;
            // 
            // CkbCancel
            // 
            CkbCancel.AutoSize = true;
            CkbCancel.Location = new Point(21, 7);
            CkbCancel.Name = "CkbCancel";
            CkbCancel.Size = new Size(63, 21);
            CkbCancel.TabIndex = 3;
            CkbCancel.Text = "已取消";
            CkbCancel.UseVisualStyleBackColor = true;
            // 
            // CbbFinish
            // 
            CbbFinish.FormattingEnabled = true;
            CbbFinish.Items.AddRange(new object[] { "已完成", "未完成" });
            CbbFinish.Location = new Point(143, 3);
            CbbFinish.Name = "CbbFinish";
            CbbFinish.Size = new Size(121, 25);
            CbbFinish.TabIndex = 4;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(302, 3);
            txtCount.Name = "txtCount";
            txtCount.PlaceholderText = "剩余数";
            txtCount.Size = new Size(100, 23);
            txtCount.TabIndex = 5;
            txtCount.TextChanged += txtCount_TextChanged;
            txtCount.KeyPress += txtCount_KeyPress;
            // 
            // BtnQuery
            // 
            BtnQuery.Location = new Point(488, 3);
            BtnQuery.Name = "BtnQuery";
            BtnQuery.Size = new Size(75, 23);
            BtnQuery.TabIndex = 6;
            BtnQuery.Text = "查 询";
            BtnQuery.UseVisualStyleBackColor = true;
            BtnQuery.Click += BtnQuery_Click;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.FillWeight = 18.79667F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            // 
            // MinCount
            // 
            MinCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MinCount.FillWeight = 18.79667F;
            MinCount.HeaderText = "最小数";
            MinCount.Name = "MinCount";
            MinCount.ReadOnly = true;
            // 
            // MaxCount
            // 
            MaxCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaxCount.FillWeight = 18.79667F;
            MaxCount.HeaderText = "最大数";
            MaxCount.Name = "MaxCount";
            MaxCount.ReadOnly = true;
            // 
            // Surplus
            // 
            Surplus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Surplus.FillWeight = 18.79667F;
            Surplus.HeaderText = "剩余数";
            Surplus.Name = "Surplus";
            Surplus.ReadOnly = true;
            // 
            // OrderType
            // 
            OrderType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderType.FillWeight = 18.79667F;
            OrderType.HeaderText = "类型";
            OrderType.Name = "OrderType";
            OrderType.ReadOnly = true;
            // 
            // OrderUser
            // 
            OrderUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderUser.FillWeight = 18.79667F;
            OrderUser.HeaderText = "用户";
            OrderUser.Name = "OrderUser";
            OrderUser.ReadOnly = true;
            // 
            // AddTime
            // 
            AddTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AddTime.FillWeight = 18.79667F;
            AddTime.HeaderText = "挂单时间";
            AddTime.Name = "AddTime";
            AddTime.ReadOnly = true;
            // 
            // IsFinish
            // 
            IsFinish.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IsFinish.FillWeight = 18.79667F;
            IsFinish.HeaderText = "状态";
            IsFinish.Name = "IsFinish";
            IsFinish.ReadOnly = true;
            // 
            // FinishTime
            // 
            FinishTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FinishTime.FillWeight = 18.79667F;
            FinishTime.HeaderText = "取消/结束时间";
            FinishTime.Name = "FinishTime";
            FinishTime.ReadOnly = true;
            // 
            // ToOpera
            // 
            ToOpera.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ToOpera.DefaultCellStyle = dataGridViewCellStyle1;
            ToOpera.FillWeight = 50F;
            ToOpera.HeaderText = "操作区";
            ToOpera.Name = "ToOpera";
            ToOpera.ReadOnly = true;
            ToOpera.Resizable = DataGridViewTriState.True;
            // 
            // DataControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnQuery);
            Controls.Add(txtCount);
            Controls.Add(CbbFinish);
            Controls.Add(CkbCancel);
            Controls.Add(panel1);
            Name = "DataControl";
            Size = new Size(989, 424);
            Load += DataControl_Load;
            Resize += DataControl_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private CheckBox CkbCancel;
        private ComboBox CbbFinish;
        private TextBox txtCount;
        private Button BtnQuery;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MinCount;
        private DataGridViewTextBoxColumn MaxCount;
        private DataGridViewTextBoxColumn Surplus;
        private DataGridViewTextBoxColumn OrderType;
        private DataGridViewTextBoxColumn OrderUser;
        private DataGridViewTextBoxColumn AddTime;
        private DataGridViewTextBoxColumn IsFinish;
        private DataGridViewTextBoxColumn FinishTime;
        private DataGridViewTextBoxColumn ToOpera;
    }
}
