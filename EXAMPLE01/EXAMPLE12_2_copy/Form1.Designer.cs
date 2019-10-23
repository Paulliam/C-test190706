namespace EXAMPLE12_2_copy
{
    partial class FormTextShow //partial表示下面的代码只是Form类的部分代码
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.输入文本框 = new System.Windows.Forms.Label();
            this.输出文本框 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.White;
            this.textBoxInput.Location = new System.Drawing.Point(33, 45);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(304, 21);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(33, 116);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(304, 21);
            this.textBoxOutput.TabIndex = 1;
            // 
            // 输入文本框
            // 
            this.输入文本框.AutoEllipsis = true;
            this.输入文本框.AutoSize = true;
            this.输入文本框.Location = new System.Drawing.Point(31, 30);
            this.输入文本框.Name = "输入文本框";
            this.输入文本框.Size = new System.Drawing.Size(77, 12);
            this.输入文本框.TabIndex = 2;
            this.输入文本框.Text = "请输入字符：";
            // 
            // 输出文本框
            // 
            this.输出文本框.AutoSize = true;
            this.输出文本框.Location = new System.Drawing.Point(31, 101);
            this.输出文本框.Name = "输出文本框";
            this.输出文本框.Size = new System.Drawing.Size(89, 12);
            this.输出文本框.TabIndex = 3;
            this.输出文本框.Text = "同步显示输出：";
            this.输出文本框.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormTextShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 206);
            this.Controls.Add(this.输出文本框);
            this.Controls.Add(this.输入文本框);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "FormTextShow";
            this.Text = "FormText";
            this.Load += new System.EventHandler(this.textBoxInput_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label 输入文本框;
        private System.Windows.Forms.Label 输出文本框;


    }
}

