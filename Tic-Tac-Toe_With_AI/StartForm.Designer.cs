namespace TicTacToe_AI
{
    partial class StartForm
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
            this.Hard_RadioButton = new System.Windows.Forms.RadioButton();
            this.Medium_RadioButton = new System.Windows.Forms.RadioButton();
            this.Easy_RadioButton = new System.Windows.Forms.RadioButton();
            this.Header_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hard_RadioButton
            // 
            this.Hard_RadioButton.AutoSize = true;
            this.Hard_RadioButton.Location = new System.Drawing.Point(258, 39);
            this.Hard_RadioButton.Name = "Hard_RadioButton";
            this.Hard_RadioButton.Size = new System.Drawing.Size(70, 27);
            this.Hard_RadioButton.TabIndex = 0;
            this.Hard_RadioButton.TabStop = true;
            this.Hard_RadioButton.Text = "Hard";
            this.Hard_RadioButton.UseVisualStyleBackColor = true;
            this.Hard_RadioButton.CheckedChanged += new System.EventHandler(this.Hard_RadioButton_CheckedChanged);
            // 
            // Medium_RadioButton
            // 
            this.Medium_RadioButton.AutoSize = true;
            this.Medium_RadioButton.Location = new System.Drawing.Point(126, 39);
            this.Medium_RadioButton.Name = "Medium_RadioButton";
            this.Medium_RadioButton.Size = new System.Drawing.Size(98, 27);
            this.Medium_RadioButton.TabIndex = 1;
            this.Medium_RadioButton.TabStop = true;
            this.Medium_RadioButton.Text = "Medium";
            this.Medium_RadioButton.UseVisualStyleBackColor = true;
            this.Medium_RadioButton.CheckedChanged += new System.EventHandler(this.Medium_RadioButton_CheckedChanged);
            // 
            // Easy_RadioButton
            // 
            this.Easy_RadioButton.AutoSize = true;
            this.Easy_RadioButton.Location = new System.Drawing.Point(21, 39);
            this.Easy_RadioButton.Name = "Easy_RadioButton";
            this.Easy_RadioButton.Size = new System.Drawing.Size(68, 27);
            this.Easy_RadioButton.TabIndex = 2;
            this.Easy_RadioButton.TabStop = true;
            this.Easy_RadioButton.Text = "Easy";
            this.Easy_RadioButton.UseVisualStyleBackColor = true;
            this.Easy_RadioButton.CheckedChanged += new System.EventHandler(this.Easy_RadioButton_CheckedChanged);
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.BackColor = System.Drawing.Color.Transparent;
            this.Header_Label.Font = new System.Drawing.Font("Jokerman", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Header_Label.Location = new System.Drawing.Point(74, 38);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(400, 93);
            this.Header_Label.TabIndex = 3;
            this.Header_Label.Text = "Tic Tac Toe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(210, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Play Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Easy_RadioButton);
            this.groupBox1.Controls.Add(this.Medium_RadioButton);
            this.groupBox1.Controls.Add(this.Hard_RadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(112, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "              Please Choose Difficulty";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe_AI.Properties.Resources.FreeVectorAbstractWhitePattern;
            this.ClientSize = new System.Drawing.Size(551, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Header_Label);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Hard_RadioButton;
        private System.Windows.Forms.RadioButton Medium_RadioButton;
        private System.Windows.Forms.RadioButton Easy_RadioButton;
        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}