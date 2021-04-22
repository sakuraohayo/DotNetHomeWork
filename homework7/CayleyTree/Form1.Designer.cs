namespace CayleyTree
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
            this.draw_button = new System.Windows.Forms.Button();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.color_comboBox = new System.Windows.Forms.ComboBox();
            this.rangle_trackBar = new System.Windows.Forms.TrackBar();
            this.langle_trackBar = new System.Windows.Forms.TrackBar();
            this.rbranch_trackBar = new System.Windows.Forms.TrackBar();
            this.lbranch_trackBar = new System.Windows.Forms.TrackBar();
            this.length_trackBar = new System.Windows.Forms.TrackBar();
            this.depth_trackBar = new System.Windows.Forms.TrackBar();
            this.color_label = new System.Windows.Forms.Label();
            this.rangle_label = new System.Windows.Forms.Label();
            this.langle_label = new System.Windows.Forms.Label();
            this.rbranch_label = new System.Windows.Forms.Label();
            this.lbranch_label = new System.Windows.Forms.Label();
            this.length_label = new System.Windows.Forms.Label();
            this.depth_label = new System.Windows.Forms.Label();
            this.draw_panel = new System.Windows.Forms.Panel();
            this.tool_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangle_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.langle_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbranch_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbranch_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(3, 3);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(95, 84);
            this.draw_button.TabIndex = 0;
            this.draw_button.Text = "Draw";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.color_comboBox);
            this.tool_panel.Controls.Add(this.rangle_trackBar);
            this.tool_panel.Controls.Add(this.langle_trackBar);
            this.tool_panel.Controls.Add(this.rbranch_trackBar);
            this.tool_panel.Controls.Add(this.lbranch_trackBar);
            this.tool_panel.Controls.Add(this.length_trackBar);
            this.tool_panel.Controls.Add(this.depth_trackBar);
            this.tool_panel.Controls.Add(this.color_label);
            this.tool_panel.Controls.Add(this.rangle_label);
            this.tool_panel.Controls.Add(this.langle_label);
            this.tool_panel.Controls.Add(this.rbranch_label);
            this.tool_panel.Controls.Add(this.lbranch_label);
            this.tool_panel.Controls.Add(this.length_label);
            this.tool_panel.Controls.Add(this.depth_label);
            this.tool_panel.Controls.Add(this.draw_button);
            this.tool_panel.Location = new System.Drawing.Point(482, 12);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(306, 426);
            this.tool_panel.TabIndex = 1;
            // 
            // color_comboBox
            // 
            this.color_comboBox.FormattingEnabled = true;
            this.color_comboBox.Items.AddRange(new object[] {
            "黑色",
            "红色",
            "黄色",
            "蓝色",
            "绿色"});
            this.color_comboBox.Location = new System.Drawing.Point(177, 359);
            this.color_comboBox.Name = "color_comboBox";
            this.color_comboBox.Size = new System.Drawing.Size(126, 23);
            this.color_comboBox.TabIndex = 14;
            this.color_comboBox.SelectedIndexChanged += new System.EventHandler(this.color_comboBox_SelectedIndexChanged);
            // 
            // rangle_trackBar
            // 
            this.rangle_trackBar.Location = new System.Drawing.Point(177, 297);
            this.rangle_trackBar.Maximum = 90;
            this.rangle_trackBar.Name = "rangle_trackBar";
            this.rangle_trackBar.Size = new System.Drawing.Size(129, 56);
            this.rangle_trackBar.TabIndex = 13;
            this.rangle_trackBar.Scroll+= new System.EventHandler(this.rangle_trackBar_Scroll);
            // 
            // langle_trackBar
            // 
            this.langle_trackBar.Location = new System.Drawing.Point(177, 245);
            this.langle_trackBar.Maximum = 90;
            this.langle_trackBar.Name = "langle_trackBar";
            this.langle_trackBar.Size = new System.Drawing.Size(126, 56);
            this.langle_trackBar.TabIndex = 12;
            this.langle_trackBar.Scroll += new System.EventHandler(this.langle_trackBar_Scroll);
            // 
            // rbranch_trackBar
            // 
            this.rbranch_trackBar.Location = new System.Drawing.Point(177, 183);
            this.rbranch_trackBar.Name = "rbranch_trackBar";
            this.rbranch_trackBar.Size = new System.Drawing.Size(126, 56);
            this.rbranch_trackBar.TabIndex = 11;
            this.rbranch_trackBar.Scroll += new System.EventHandler(this.rbranch_trackBar_Scroll);
            // 
            // lbranch_trackBar
            // 
            this.lbranch_trackBar.Location = new System.Drawing.Point(177, 124);
            this.lbranch_trackBar.Name = "lbranch_trackBar";
            this.lbranch_trackBar.Size = new System.Drawing.Size(126, 56);
            this.lbranch_trackBar.TabIndex = 10;
            this.lbranch_trackBar.Scroll += new System.EventHandler(this.lbranch_trackBar_Scroll);
            // 
            // length_trackBar
            // 
            this.length_trackBar.Location = new System.Drawing.Point(177, 62);
            this.length_trackBar.Maximum = 100;
            this.length_trackBar.Minimum = 10;
            this.length_trackBar.Name = "length_trackBar";
            this.length_trackBar.Size = new System.Drawing.Size(126, 56);
            this.length_trackBar.TabIndex = 9;
            this.length_trackBar.Scroll += new System.EventHandler(this.length_trackBar_Scroll);
            // 
            // depth_trackBar
            // 
            this.depth_trackBar.Location = new System.Drawing.Point(177, 3);
            this.depth_trackBar.Maximum = 30;
            this.depth_trackBar.Name = "depth_trackBar";
            this.depth_trackBar.Size = new System.Drawing.Size(126, 56);
            this.depth_trackBar.TabIndex = 8;
            this.depth_trackBar.Scroll += new System.EventHandler(this.depth_trackBar_Scroll);
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(41, 367);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(37, 15);
            this.color_label.TabIndex = 7;
            this.color_label.Text = "颜色";
            // 
            // rangle_label
            // 
            this.rangle_label.AutoSize = true;
            this.rangle_label.Location = new System.Drawing.Point(41, 311);
            this.rangle_label.Name = "rangle_label";
            this.rangle_label.Size = new System.Drawing.Size(82, 15);
            this.rangle_label.TabIndex = 6;
            this.rangle_label.Text = "右分支角度";
            // 
            // langle_label
            // 
            this.langle_label.AutoSize = true;
            this.langle_label.Location = new System.Drawing.Point(41, 255);
            this.langle_label.Name = "langle_label";
            this.langle_label.Size = new System.Drawing.Size(82, 15);
            this.langle_label.TabIndex = 5;
            this.langle_label.Text = "左分支角度";
            // 
            // rbranch_label
            // 
            this.rbranch_label.AutoSize = true;
            this.rbranch_label.Location = new System.Drawing.Point(41, 196);
            this.rbranch_label.Name = "rbranch_label";
            this.rbranch_label.Size = new System.Drawing.Size(97, 15);
            this.rbranch_label.TabIndex = 4;
            this.rbranch_label.Text = "右分支长度比";
            // 
            // lbranch_label
            // 
            this.lbranch_label.AutoSize = true;
            this.lbranch_label.Location = new System.Drawing.Point(41, 133);
            this.lbranch_label.Name = "lbranch_label";
            this.lbranch_label.Size = new System.Drawing.Size(97, 15);
            this.lbranch_label.TabIndex = 3;
            this.lbranch_label.Text = "左分支长度比";
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Location = new System.Drawing.Point(104, 72);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(67, 15);
            this.length_label.TabIndex = 2;
            this.length_label.Text = "主干长度";
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Location = new System.Drawing.Point(104, 11);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(67, 15);
            this.depth_label.TabIndex = 1;
            this.depth_label.Text = "递归深度";
            // 
            // draw_panel
            // 
            this.draw_panel.Location = new System.Drawing.Point(12, 15);
            this.draw_panel.Name = "draw_panel";
            this.draw_panel.Size = new System.Drawing.Size(464, 423);
            this.draw_panel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.draw_panel);
            this.Controls.Add(this.tool_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangle_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.langle_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbranch_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbranch_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depth_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.Label rangle_label;
        private System.Windows.Forms.Label langle_label;
        private System.Windows.Forms.Label rbranch_label;
        private System.Windows.Forms.Label lbranch_label;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.TrackBar depth_trackBar;
        private System.Windows.Forms.ComboBox color_comboBox;
        private System.Windows.Forms.TrackBar rangle_trackBar;
        private System.Windows.Forms.TrackBar langle_trackBar;
        private System.Windows.Forms.TrackBar rbranch_trackBar;
        private System.Windows.Forms.TrackBar lbranch_trackBar;
        private System.Windows.Forms.TrackBar length_trackBar;
        private System.Windows.Forms.Panel draw_panel;
    }
}

