namespace Practica_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Elephant", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(188, 39);
            label1.Name = "label1";
            label1.Size = new Size(271, 64);
            label1.TabIndex = 0;
            label1.Text = "= Suma =";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 172);
            label2.Name = "label2";
            label2.Size = new Size(248, 36);
            label2.TabIndex = 1;
            label2.Text = "Primer Numero:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 253);
            label3.Name = "label3";
            label3.Size = new Size(279, 36);
            label3.TabIndex = 2;
            label3.Text = "Segundo Numero:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(320, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 50);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(320, 243);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(273, 50);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 354);
            label4.Name = "label4";
            label4.Size = new Size(332, 38);
            label4.TabIndex = 5;
            label4.Text = "La suma es es igual a:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Font = new Font("Rockwell", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(253, 449);
            button1.Name = "button1";
            button1.Size = new Size(144, 56);
            button1.TabIndex = 6;
            button1.Text = "SUMAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(624, 548);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
    }
}