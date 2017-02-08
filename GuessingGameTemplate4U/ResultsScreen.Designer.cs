namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.guessNumLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessOrderLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultsLabel.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.resultsLabel.Location = new System.Drawing.Point(13, -20);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(268, 112);
            this.resultsLabel.TabIndex = 0;
            this.resultsLabel.Text = "Results";
            this.resultsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.resultsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.resultsGroupBox.Controls.Add(this.guessOrderLabel);
            this.resultsGroupBox.Controls.Add(this.guessLabel);
            this.resultsGroupBox.Controls.Add(this.guessNumLabel);
            this.resultsGroupBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultsGroupBox.ForeColor = System.Drawing.Color.GreenYellow;
            this.resultsGroupBox.Location = new System.Drawing.Point(3, 71);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(294, 226);
            this.resultsGroupBox.TabIndex = 1;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Guesses";
            // 
            // guessNumLabel
            // 
            this.guessNumLabel.AutoSize = true;
            this.guessNumLabel.Location = new System.Drawing.Point(9, 31);
            this.guessNumLabel.Name = "guessNumLabel";
            this.guessNumLabel.Size = new System.Drawing.Size(103, 13);
            this.guessNumLabel.TabIndex = 0;
            this.guessNumLabel.Text = "Number of Guesses:";
            // 
            // guessLabel
            // 
            this.guessLabel.Location = new System.Drawing.Point(9, 66);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(269, 68);
            this.guessLabel.TabIndex = 0;
            this.guessLabel.Text = "Guesses:";
            // 
            // guessOrderLabel
            // 
            this.guessOrderLabel.Location = new System.Drawing.Point(9, 134);
            this.guessOrderLabel.Name = "guessOrderLabel";
            this.guessOrderLabel.Size = new System.Drawing.Size(269, 89);
            this.guessOrderLabel.TabIndex = 0;
            this.guessOrderLabel.Text = "Guesses In Order:";
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::GuessingGameTemplate4U.Properties.Resources.QMark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.resultsLabel);
            this.DoubleBuffered = true;
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(300, 300);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Label guessOrderLabel;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Label guessNumLabel;
    }
}
