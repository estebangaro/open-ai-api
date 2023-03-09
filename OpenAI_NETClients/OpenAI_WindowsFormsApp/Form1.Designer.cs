namespace OpenAI_WindowsFormsApp
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 176);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Envíar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(663, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 2;
            label1.Text = "¡Pregúntame algo!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(743, 20);
            label2.TabIndex = 3;
            label2.Text = "The OpenAI API can be applied to virtually any task that involves understanding or generating natural language";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 32);
            label3.Name = "label3";
            label3.Size = new Size(698, 20);
            label3.TabIndex = 4;
            label3.Text = "or code. We offer a spectrum of models with different levels of power suitable for different tasks, as well";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 56);
            label4.Name = "label4";
            label4.Size = new Size(712, 20);
            label4.TabIndex = 5;
            label4.Text = "as the ability to fine-tune your own custom models. These models can be used for everything from content";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 80);
            label5.Name = "label5";
            label5.Size = new Size(329, 20);
            label5.TabIndex = 6;
            label5.Text = "generation to semantic search and classification.";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 240);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 204);
            listBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 207);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "OpenAI API Windows Form Test Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private Label label7;
    }
}