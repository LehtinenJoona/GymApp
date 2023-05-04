namespace GymApp2
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
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel23 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel23);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-4, 25);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 753);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.Gold;
            button6.FlatAppearance.BorderColor = Color.Black;
            button6.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button6.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(784, 365);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(350, 153);
            button6.TabIndex = 6;
            button6.Text = "Cardio";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.FlatAppearance.BorderColor = Color.Black;
            button5.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button5.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(399, 365);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(351, 153);
            button5.TabIndex = 5;
            button5.Text = "Abs";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button4.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(17, 365);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(352, 153);
            button4.TabIndex = 4;
            button4.Text = "Arms";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel23
            // 
            panel23.AutoSize = true;
            panel23.BackColor = Color.Gold;
            panel23.BorderStyle = BorderStyle.Fixed3D;
            panel23.Font = new Font("Gill Sans Ultra Bold Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point);
            panel23.Location = new Point(399, 27);
            panel23.Margin = new Padding(4, 0, 4, 0);
            panel23.Name = "panel23";
            panel23.Padding = new Padding(3, 0, 0, 1);
            panel23.Size = new Size(383, 101);
            panel23.TabIndex = 0;
            panel23.Text = "SUPERGYM";
            panel23.Click += panel23_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button3.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(784, 178);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Padding = new Padding(3, 0, 0, 1);
            button3.Size = new Size(350, 153);
            button3.TabIndex = 2;
            button3.Text = "Chest";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button2.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(399, 178);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(351, 153);
            button2.TabIndex = 1;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += panel24_click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button1.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(17, 178);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(352, 153);
            button1.TabIndex = 0;
            button1.Text = "Legs";
            button1.UseVisualStyleBackColor = false;
            button1.Click += panel23_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label panel23;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}