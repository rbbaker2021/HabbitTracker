namespace HabbitTracker
{
    partial class HabbitTrackerForm
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
            this.currentHabbitLabel = new System.Windows.Forms.Label();
            this.enterHabbitTextBox = new System.Windows.Forms.TextBox();
            this.addHabbitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentHabbitLabel
            // 
            this.currentHabbitLabel.AutoSize = true;
            this.currentHabbitLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.currentHabbitLabel.Location = new System.Drawing.Point(85, 47);
            this.currentHabbitLabel.Name = "currentHabbitLabel";
            this.currentHabbitLabel.Size = new System.Drawing.Size(35, 13);
            this.currentHabbitLabel.TabIndex = 0;
            this.currentHabbitLabel.Text = "label1";
            this.currentHabbitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterHabbitTextBox
            // 
            this.enterHabbitTextBox.Location = new System.Drawing.Point(544, 40);
            this.enterHabbitTextBox.Name = "enterHabbitTextBox";
            this.enterHabbitTextBox.Size = new System.Drawing.Size(100, 20);
            this.enterHabbitTextBox.TabIndex = 1;
            // 
            // addHabbitButton
            // 
            this.addHabbitButton.AutoSize = true;
            this.addHabbitButton.Location = new System.Drawing.Point(673, 37);
            this.addHabbitButton.Name = "addHabbitButton";
            this.addHabbitButton.Size = new System.Drawing.Size(98, 23);
            this.addHabbitButton.TabIndex = 2;
            this.addHabbitButton.Text = "Start New Habbit";
            this.addHabbitButton.UseVisualStyleBackColor = true;
            this.addHabbitButton.Click += new System.EventHandler(this.addHabbitButton_Click);
            // 
            // HabbitTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addHabbitButton);
            this.Controls.Add(this.enterHabbitTextBox);
            this.Controls.Add(this.currentHabbitLabel);
            this.Name = "HabbitTrackerForm";
            this.Text = "HabbitTrackerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentHabbitLabel;
        private System.Windows.Forms.TextBox enterHabbitTextBox;
        private System.Windows.Forms.Button addHabbitButton;
    }
}