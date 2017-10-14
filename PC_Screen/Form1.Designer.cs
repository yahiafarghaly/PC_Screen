namespace PC_Screen
{
    partial class PC_screenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReadTextBox = new System.Windows.Forms.RichTextBox();
            this.PortLists = new System.Windows.Forms.ComboBox();
            this.serialPortRead = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelstatus = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.Infobtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadTextBox
            // 
            this.ReadTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ReadTextBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadTextBox.Location = new System.Drawing.Point(12, 12);
            this.ReadTextBox.Name = "ReadTextBox";
            this.ReadTextBox.ReadOnly = true;
            this.ReadTextBox.Size = new System.Drawing.Size(656, 200);
            this.ReadTextBox.TabIndex = 0;
            this.ReadTextBox.Text = "";
            this.ReadTextBox.TextChanged += new System.EventHandler(this.ReadTextBox_TextChanged);
            // 
            // PortLists
            // 
            this.PortLists.FormattingEnabled = true;
            this.PortLists.Location = new System.Drawing.Point(6, 19);
            this.PortLists.Name = "PortLists";
            this.PortLists.Size = new System.Drawing.Size(83, 21);
            this.PortLists.TabIndex = 1;
            this.PortLists.Text = "Choose";
            this.PortLists.SelectedIndexChanged += new System.EventHandler(this.PortLists_SelectedIndexChanged);
            // 
            // serialPortRead
            // 
            this.serialPortRead.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRead_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndBtn);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.RefreshBtn);
            this.groupBox1.Controls.Add(this.PortLists);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Serial Port";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(262, 19);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(75, 23);
            this.EndBtn.TabIndex = 3;
            this.EndBtn.Text = "End";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(100, 18);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.InitBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(181, 18);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelstatus);
            this.groupBox2.Location = new System.Drawing.Point(379, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Port Status";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstatus.Location = new System.Drawing.Point(6, 21);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(122, 14);
            this.labelstatus.TabIndex = 0;
            this.labelstatus.Text = "Please Choose a port";
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(553, 232);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(55, 32);
            this.clearbtn.TabIndex = 4;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Infobtn
            // 
            this.Infobtn.Location = new System.Drawing.Point(614, 232);
            this.Infobtn.Name = "Infobtn";
            this.Infobtn.Size = new System.Drawing.Size(54, 32);
            this.Infobtn.TabIndex = 5;
            this.Infobtn.Text = "Info";
            this.Infobtn.UseVisualStyleBackColor = true;
            this.Infobtn.Click += new System.EventHandler(this.Settingbtn_Click);
            // 
            // PC_screenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 271);
            this.Controls.Add(this.Infobtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReadTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PC_screenForm";
            this.ShowIcon = false;
            this.Text = "PC Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PC_screenForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReadTextBox;
        private System.Windows.Forms.ComboBox PortLists;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button EndBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button Infobtn;
        public System.IO.Ports.SerialPort serialPortRead;
    }
}

