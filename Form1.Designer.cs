namespace WinFormsTestApp
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
            btnGreet = new Button();
            lblPrompt = new Label();
            txtInput = new TextBox();
            lblPreview = new Label();
            btnReset = new Button();
            btnAbout = new Button();
            SuspendLayout();
            // 
            // btnGreet
            // 
            btnGreet.Enabled = false;
            btnGreet.Location = new Point(102, 231);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(547, 31);
            btnGreet.TabIndex = 0;
            btnGreet.Text = "Greeting";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += button1_Click;
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(102, 156);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(120, 20);
            lblPrompt.TabIndex = 1;
            lblPrompt.Text = "Enter your name:";
            lblPrompt.Click += label1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(256, 156);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(393, 27);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.Location = new Point(102, 329);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(63, 20);
            lblPreview.TabIndex = 3;
            lblPreview.Text = "Preview:";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(555, 320);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(102, 57);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(94, 29);
            btnAbout.TabIndex = 5;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbout);
            Controls.Add(btnReset);
            Controls.Add(lblPreview);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            Controls.Add(btnGreet);
            Name = "Form1";
            Text = "Greeting Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGreet;
        private Label lblPrompt;
        private TextBox txtInput;
        private Label lblPreview;
        private Button btnReset;
        private Button btnAbout;
    }
}
