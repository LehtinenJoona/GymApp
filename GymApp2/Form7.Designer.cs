namespace GymApp2
{
    partial class Form7
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 40;
            listBox1.Items.AddRange(new object[] { "Warm-up:", "- 5-10 minutes of light cardio (e.g. jogging on the treadmill, cycling)", "", "Cardio:", "- 30 seconds of sprinting followed by 30 seconds of rest, repeat for 10-15 minutes", "- Stairmaster: 10-15 minutes at a moderate pace", "", " Cooldown:", "- 10-15 minutes of light cardio", "- Stretching exercises for legs and lower back" });
            listBox1.Location = new Point(1, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1074, 444);
            listBox1.TabIndex = 0;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 442);
            Controls.Add(listBox1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}