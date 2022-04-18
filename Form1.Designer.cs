namespace Activity_8
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
            this.fatLabel = new System.Windows.Forms.Label();
            this.fatConsumed = new System.Windows.Forms.TextBox();
            this.fatButton = new System.Windows.Forms.Button();
            this.fatCalories = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.carbsConsumed = new System.Windows.Forms.TextBox();
            this.carbsButton = new System.Windows.Forms.Button();
            this.carbsCalories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(34, 31);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(148, 13);
            this.fatLabel.TabIndex = 0;
            this.fatLabel.Text = "Enter  grams of fat consumed:";
            // 
            // fatConsumed
            // 
            this.fatConsumed.Location = new System.Drawing.Point(218, 28);
            this.fatConsumed.Name = "fatConsumed";
            this.fatConsumed.Size = new System.Drawing.Size(100, 20);
            this.fatConsumed.TabIndex = 1;
            // 
            // fatButton
            // 
            this.fatButton.Location = new System.Drawing.Point(334, 20);
            this.fatButton.Name = "fatButton";
            this.fatButton.Size = new System.Drawing.Size(75, 35);
            this.fatButton.TabIndex = 2;
            this.fatButton.Text = "Calculate";
            this.fatButton.UseVisualStyleBackColor = true;
            this.fatButton.Click += new System.EventHandler(this.fatButton_Click_1);
            // 
            // fatCalories
            // 
            this.fatCalories.AutoSize = true;
            this.fatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatCalories.Location = new System.Drawing.Point(34, 64);
            this.fatCalories.Name = "fatCalories";
            this.fatCalories.Size = new System.Drawing.Size(0, 13);
            this.fatCalories.TabIndex = 3;
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(34, 102);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(166, 13);
            this.carbsLabel.TabIndex = 4;
            this.carbsLabel.Text = "Enter the grams of carbohydrates:";
            // 
            // carbsConsumed
            // 
            this.carbsConsumed.Location = new System.Drawing.Point(218, 102);
            this.carbsConsumed.Name = "carbsConsumed";
            this.carbsConsumed.Size = new System.Drawing.Size(100, 20);
            this.carbsConsumed.TabIndex = 5;
            // 
            // carbsButton
            // 
            this.carbsButton.Location = new System.Drawing.Point(334, 93);
            this.carbsButton.Name = "carbsButton";
            this.carbsButton.Size = new System.Drawing.Size(75, 36);
            this.carbsButton.TabIndex = 6;
            this.carbsButton.Text = "Calculate";
            this.carbsButton.UseVisualStyleBackColor = true;
            this.carbsButton.Click += new System.EventHandler(this.carbsButton_Click);
            // 
            // carbsCalories
            // 
            this.carbsCalories.AutoSize = true;
            this.carbsCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsCalories.Location = new System.Drawing.Point(34, 136);
            this.carbsCalories.Name = "carbsCalories";
            this.carbsCalories.Size = new System.Drawing.Size(0, 13);
            this.carbsCalories.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 205);
            this.Controls.Add(this.carbsCalories);
            this.Controls.Add(this.carbsButton);
            this.Controls.Add(this.carbsConsumed);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatCalories);
            this.Controls.Add(this.fatButton);
            this.Controls.Add(this.fatConsumed);
            this.Controls.Add(this.fatLabel);
            this.Name = "Form1";
            this.Text = "Calculate Calories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.TextBox fatConsumed;
        private System.Windows.Forms.Button fatButton;
        private System.Windows.Forms.Label fatCalories;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.TextBox carbsConsumed;
        private System.Windows.Forms.Button carbsButton;
        private System.Windows.Forms.Label carbsCalories;
    }
}

