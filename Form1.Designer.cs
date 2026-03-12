namespace CatchButton
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
            RunningButton = new Button();
            SuspendLayout();
            // 
            // RunningButton
            // 
            RunningButton.BackColor = SystemColors.ActiveCaptionText;
            RunningButton.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RunningButton.ForeColor = SystemColors.ButtonFace;
            RunningButton.Location = new Point(100, 153);
            RunningButton.Name = "RunningButton";
            RunningButton.Size = new Size(305, 82);
            RunningButton.TabIndex = 0;
            RunningButton.Text = "나를 잡아봐";
            RunningButton.UseVisualStyleBackColor = false;
            RunningButton.MouseDown += RunningButton_MouseDown;
            RunningButton.MouseEnter += RunningButton_MouseEnter;
            RunningButton.MouseLeave += RunningButton_MouseLeave;
            RunningButton.MouseUp += RunningButton_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RunningButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button RunningButton;
    }
}
