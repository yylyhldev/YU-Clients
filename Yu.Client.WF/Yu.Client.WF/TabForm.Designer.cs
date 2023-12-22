namespace Yu.Client.WF
{
    partial class TabForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabForm));
            panel1 = new Panel();
            BtnData = new Button();
            BtnMap = new Button();
            BtnBle = new Button();
            BtnMedia = new Button();
            BtnSocket = new Button();
            BtnOther = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(145, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 413);
            panel1.TabIndex = 0;
            // 
            // BtnData
            // 
            BtnData.Location = new Point(12, 12);
            BtnData.Name = "BtnData";
            BtnData.Size = new Size(112, 52);
            BtnData.TabIndex = 1;
            BtnData.Text = "数据加载";
            BtnData.UseVisualStyleBackColor = true;
            BtnData.Click += BtnData_Click;
            // 
            // BtnMap
            // 
            BtnMap.Location = new Point(12, 87);
            BtnMap.Name = "BtnMap";
            BtnMap.Size = new Size(112, 52);
            BtnMap.TabIndex = 1;
            BtnMap.Text = "地图";
            BtnMap.UseVisualStyleBackColor = true;
            BtnMap.Click += BtnMap_Click;
            // 
            // BtnBle
            // 
            BtnBle.Location = new Point(12, 160);
            BtnBle.Name = "BtnBle";
            BtnBle.Size = new Size(112, 52);
            BtnBle.TabIndex = 1;
            BtnBle.Text = "蓝牙";
            BtnBle.UseVisualStyleBackColor = true;
            BtnBle.Click += BtnBle_Click;
            // 
            // BtnMedia
            // 
            BtnMedia.Location = new Point(12, 232);
            BtnMedia.Name = "BtnMedia";
            BtnMedia.Size = new Size(112, 52);
            BtnMedia.TabIndex = 1;
            BtnMedia.Text = "图片影音";
            BtnMedia.UseVisualStyleBackColor = true;
            BtnMedia.Click += BtnMedia_Click;
            // 
            // BtnSocket
            // 
            BtnSocket.Location = new Point(12, 306);
            BtnSocket.Name = "BtnSocket";
            BtnSocket.Size = new Size(112, 52);
            BtnSocket.TabIndex = 1;
            BtnSocket.Text = "Socket";
            BtnSocket.UseVisualStyleBackColor = true;
            BtnSocket.Click += BtnSocket_Click;
            // 
            // BtnOther
            // 
            BtnOther.Location = new Point(12, 373);
            BtnOther.Name = "BtnOther";
            BtnOther.Size = new Size(112, 52);
            BtnOther.TabIndex = 1;
            BtnOther.Text = "其他";
            BtnOther.UseVisualStyleBackColor = true;
            BtnOther.Click += BtnOther_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnOther);
            Controls.Add(BtnSocket);
            Controls.Add(BtnMedia);
            Controls.Add(BtnBle);
            Controls.Add(BtnMap);
            Controls.Add(BtnData);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Yu.Client.WF";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnData;
        private Button BtnMap;
        private Button BtnBle;
        private Button BtnMedia;
        private Button BtnSocket;
        private Button BtnOther;
    }
}
