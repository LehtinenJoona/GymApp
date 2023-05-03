namespace GymApp2
{
    partial class Form2
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
            kyykky = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // kyykky
            // 
            kyykky.AutoSize = true;
            kyykky.Location = new Point(23, 22);
            kyykky.Name = "kyykky";
            kyykky.Size = new Size(73, 15);
            kyykky.TabIndex = 0;
            kyykky.Text = "3x10 kyykky ";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 45;
            listBox1.Items.AddRange(new object[] { "• Barbell squats: 3 sets of 8-12 reps", "• Leg press: 3 sets of 10-15 reps", "• Walking lunges: 3 sets of 12-16 reps per leg", "• Romanian deadlifts: 3 sets of 10-12 reps" });
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 409);
            listBox1.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(kyykky);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kyykky;
        private ListBox listBox1;
    }
}