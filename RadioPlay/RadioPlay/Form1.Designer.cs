namespace RadioPlay
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Show_but = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Color_back = new System.Windows.Forms.Label();
            this.Color_font = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear);
            this.groupBox1.Controls.Add(this.Show_but);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Color_back);
            this.groupBox1.Controls.Add(this.Color_font);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14F);
            this.groupBox1.Location = new System.Drawing.Point(519, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字幕设置";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(263, 416);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(92, 46);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "清 空";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // Show_but
            // 
            this.Show_but.Location = new System.Drawing.Point(486, 416);
            this.Show_but.Name = "Show_but";
            this.Show_but.Size = new System.Drawing.Size(92, 46);
            this.Show_but.TabIndex = 10;
            this.Show_but.Text = "展 示";
            this.Show_but.UseVisualStyleBackColor = true;
            this.Show_but.Click += new System.EventHandler(this.Show_but_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(374, 416);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(92, 46);
            this.Delete.TabIndex = 9;
            this.Delete.Text = "删 除";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(153, 416);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 46);
            this.Update.TabIndex = 8;
            this.Update.Text = "修 改";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(45, 416);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 46);
            this.Save.TabIndex = 7;
            this.Save.Text = "保 存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Crimson;
            this.textBox2.Location = new System.Drawing.Point(45, 168);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(680, 237);
            this.textBox2.TabIndex = 6;
            // 
            // Color_back
            // 
            this.Color_back.AutoSize = true;
            this.Color_back.Location = new System.Drawing.Point(358, 106);
            this.Color_back.Name = "Color_back";
            this.Color_back.Size = new System.Drawing.Size(95, 19);
            this.Color_back.TabIndex = 5;
            this.Color_back.Text = "背景颜色:";
            // 
            // Color_font
            // 
            this.Color_font.AutoSize = true;
            this.Color_font.Location = new System.Drawing.Point(41, 106);
            this.Color_font.Name = "Color_font";
            this.Color_font.Size = new System.Drawing.Size(95, 19);
            this.Color_font.TabIndex = 4;
            this.Color_font.Text = "字幕颜色:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 29);
            this.textBox1.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(358, 53);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(76, 19);
            this.Title.TabIndex = 2;
            this.Title.Text = "题 目：";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(41, 53);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(76, 19);
            this.Time.TabIndex = 1;
            this.Time.Text = "时 间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // colorDialog2
            // 
            this.colorDialog2.FullOpen = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 467);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史字幕";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "字幕程序";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Color_back;
        private System.Windows.Forms.Label Color_font;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Show_but;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Clear;
    }
}

