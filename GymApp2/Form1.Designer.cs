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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel23 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 405);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button1.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(21, 180);
            button1.Name = "button1";
            button1.Size = new Size(156, 143);
            button1.TabIndex = 0;
            button1.Text = "Legs";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button2.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(302, 180);
            button2.Name = "button2";
            button2.Size = new Size(156, 143);
            button2.TabIndex = 1;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.MistyRose;
            button3.FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(572, 180);
            button3.Name = "button3";
            button3.Size = new Size(156, 143);
            button3.TabIndex = 2;
            button3.Text = "Chest";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AccessibleName = "";
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(panel23);
            panel2.Location = new Point(21, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 83);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel23
            // 
            panel23.AutoSize = true;
            panel23.BackColor = Color.Yellow;
            panel23.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            panel23.Location = new Point(229, 9);
            panel23.Name = "panel23";
            panel23.Size = new Size(285, 65);
            panel23.TabIndex = 0;
            panel23.Text = "SUPERGYM";
            panel23.Click += panel23_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label panel23;
    }
}