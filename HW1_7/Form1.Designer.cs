namespace HW1_7
{
    partial class Form1
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 322);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 7;
            label2.Text = "星期日:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 299);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 6;
            label1.Text = "星期六:";
            // 
            // button1
            // 
            button1.Location = new Point(325, 205);
            button1.Name = "button1";
            button1.Size = new Size(150, 71);
            button1.TabIndex = 5;
            button1.Text = "計算週六週日";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 108);
            label3.Name = "label3";
            label3.Size = new Size(46, 23);
            label3.TabIndex = 8;
            label3.Text = "西元";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 108);
            label4.Name = "label4";
            label4.Size = new Size(28, 23);
            label4.TabIndex = 9;
            label4.Text = "年";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
    }
}
