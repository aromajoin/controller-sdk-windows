namespace ControllerSample
{
    partial class Form1
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
            this.Cartridge1 = new System.Windows.Forms.Button();
            this.Cartridge2 = new System.Windows.Forms.Button();
            this.Cartridge3 = new System.Windows.Forms.Button();
            this.Cartridge4 = new System.Windows.Forms.Button();
            this.Cartridge5 = new System.Windows.Forms.Button();
            this.Cartridge6 = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cartridge1
            // 
            this.Cartridge1.Location = new System.Drawing.Point(42, 172);
            this.Cartridge1.Margin = new System.Windows.Forms.Padding(6);
            this.Cartridge1.Name = "Cartridge1";
            this.Cartridge1.Size = new System.Drawing.Size(138, 46);
            this.Cartridge1.TabIndex = 0;
            this.Cartridge1.Text = "Cartridge1";
            this.Cartridge1.UseVisualStyleBackColor = true;
            this.Cartridge1.Click += new System.EventHandler(this.Cartridge1_Click);
            // 
            // Cartridge2
            // 
            this.Cartridge2.Location = new System.Drawing.Point(315, 172);
            this.Cartridge2.Margin = new System.Windows.Forms.Padding(6);
            this.Cartridge2.Name = "Cartridge2";
            this.Cartridge2.Size = new System.Drawing.Size(138, 46);
            this.Cartridge2.TabIndex = 1;
            this.Cartridge2.Text = "Cartridge2";
            this.Cartridge2.UseVisualStyleBackColor = true;
            this.Cartridge2.Click += new System.EventHandler(this.Cartridge2_Click);
            // 
            // Cartridge3
            // 
            this.Cartridge3.Location = new System.Drawing.Point(596, 172);
            this.Cartridge3.Margin = new System.Windows.Forms.Padding(6);
            this.Cartridge3.Name = "Cartridge3";
            this.Cartridge3.Size = new System.Drawing.Size(138, 46);
            this.Cartridge3.TabIndex = 2;
            this.Cartridge3.Text = "Cartridge3";
            this.Cartridge3.UseVisualStyleBackColor = true;
            this.Cartridge3.Click += new System.EventHandler(this.Cartridge3_Click);
            // 
            // Cartridge4
            // 
            this.Cartridge4.Location = new System.Drawing.Point(42, 304);
            this.Cartridge4.Margin = new System.Windows.Forms.Padding(6);
            this.Cartridge4.Name = "Cartridge4";
            this.Cartridge4.Size = new System.Drawing.Size(138, 46);
            this.Cartridge4.TabIndex = 3;
            this.Cartridge4.Text = "Cartridge4";
            this.Cartridge4.UseVisualStyleBackColor = true;
            this.Cartridge4.Click += new System.EventHandler(this.Cartridge4_Click);
            // 
            // Cartridge5
            // 
            this.Cartridge5.Location = new System.Drawing.Point(315, 304);
            this.Cartridge5.Margin = new System.Windows.Forms.Padding(6);
            this.Cartridge5.Name = "Cartridge5";
            this.Cartridge5.Size = new System.Drawing.Size(138, 46);
            this.Cartridge5.TabIndex = 4;
            this.Cartridge5.Text = "Cartridge5";
            this.Cartridge5.UseVisualStyleBackColor = true;
            this.Cartridge5.Click += new System.EventHandler(this.Cartridge5_Click);
            // 
            // Cartridge6
            // 
            this.Cartridge6.Location = new System.Drawing.Point(596, 304);
            this.Cartridge6.Margin = new System.Windows.Forms.Padding(6);
            this.Cartridge6.Name = "Cartridge6";
            this.Cartridge6.Size = new System.Drawing.Size(138, 46);
            this.Cartridge6.TabIndex = 5;
            this.Cartridge6.Text = "Cartridge6";
            this.Cartridge6.UseVisualStyleBackColor = true;
            this.Cartridge6.Click += new System.EventHandler(this.Cartridge6_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(224, 399);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(293, 64);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 522);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Cartridge6);
            this.Controls.Add(this.Cartridge5);
            this.Controls.Add(this.Cartridge4);
            this.Controls.Add(this.Cartridge3);
            this.Controls.Add(this.Cartridge2);
            this.Controls.Add(this.Cartridge1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "AromaShooterControllerSample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cartridge1;
        private System.Windows.Forms.Button Cartridge2;
        private System.Windows.Forms.Button Cartridge3;
        private System.Windows.Forms.Button Cartridge4;
        private System.Windows.Forms.Button Cartridge5;
        private System.Windows.Forms.Button Cartridge6;
        private System.Windows.Forms.Button StopButton;
    }
}

