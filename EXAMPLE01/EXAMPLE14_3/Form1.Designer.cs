namespace EXAMPLE14_3
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxOpen = new System.Windows.Forms.TextBox();
            this.textBoxSave = new System.Windows.Forms.TextBox();
            this.buttonBrows = new System.Windows.Forms.Button();
            this.textBoxBrows = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.buttonFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(42, 39);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "OpenFile";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(42, 124);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "SaveFile";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxOpen
            // 
            this.textBoxOpen.Location = new System.Drawing.Point(42, 68);
            this.textBoxOpen.Name = "textBoxOpen";
            this.textBoxOpen.Size = new System.Drawing.Size(570, 21);
            this.textBoxOpen.TabIndex = 2;
            // 
            // textBoxSave
            // 
            this.textBoxSave.Location = new System.Drawing.Point(42, 153);
            this.textBoxSave.Name = "textBoxSave";
            this.textBoxSave.Size = new System.Drawing.Size(570, 21);
            this.textBoxSave.TabIndex = 3;
            // 
            // buttonBrows
            // 
            this.buttonBrows.Location = new System.Drawing.Point(42, 200);
            this.buttonBrows.Name = "buttonBrows";
            this.buttonBrows.Size = new System.Drawing.Size(75, 23);
            this.buttonBrows.TabIndex = 4;
            this.buttonBrows.Text = "BrowsFile";
            this.buttonBrows.UseVisualStyleBackColor = true;
            this.buttonBrows.Click += new System.EventHandler(this.buttonBrows_Click);
            // 
            // textBoxBrows
            // 
            this.textBoxBrows.Location = new System.Drawing.Point(42, 229);
            this.textBoxBrows.Name = "textBoxBrows";
            this.textBoxBrows.Size = new System.Drawing.Size(570, 21);
            this.textBoxBrows.TabIndex = 5;
            // 
            // textBoxColor
            // 
            this.textBoxColor.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxColor.Location = new System.Drawing.Point(42, 304);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(570, 21);
            this.textBoxColor.TabIndex = 7;
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(42, 275);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "GetColor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxFont
            // 
            this.textBoxFont.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFont.Location = new System.Drawing.Point(42, 374);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(570, 21);
            this.textBoxFont.TabIndex = 9;
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(42, 345);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(75, 23);
            this.buttonFont.TabIndex = 8;
            this.buttonFont.Text = "GetFont";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 418);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.textBoxBrows);
            this.Controls.Add(this.buttonBrows);
            this.Controls.Add(this.textBoxSave);
            this.Controls.Add(this.textBoxOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxOpen;
        private System.Windows.Forms.TextBox textBoxSave;
        private System.Windows.Forms.Button buttonBrows;
        private System.Windows.Forms.TextBox textBoxBrows;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Button buttonFont;
    }
}

