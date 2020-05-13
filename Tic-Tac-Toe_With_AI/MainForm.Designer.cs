namespace Tic_Tac_Toe_With_AI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.Player_Wins_Label = new System.Windows.Forms.Label();
            this.AI_Wins_Label = new System.Windows.Forms.Label();
            this.Button00 = new System.Windows.Forms.Button();
            this.Button01 = new System.Windows.Forms.Button();
            this.Button02 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button22 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.Button21 = new System.Windows.Forms.Button();
            this.Button20 = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Player_Wins_Label
            // 
            this.Player_Wins_Label.AutoSize = true;
            this.Player_Wins_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Player_Wins_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Player_Wins_Label.Location = new System.Drawing.Point(12, 13);
            this.Player_Wins_Label.Name = "Player_Wins_Label";
            this.Player_Wins_Label.Size = new System.Drawing.Size(123, 20);
            this.Player_Wins_Label.TabIndex = 0;
            this.Player_Wins_Label.Text = "Player Wins -0";
            // 
            // AI_Wins_Label
            // 
            this.AI_Wins_Label.AutoSize = true;
            this.AI_Wins_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AI_Wins_Label.ForeColor = System.Drawing.Color.DarkOrange;
            this.AI_Wins_Label.Location = new System.Drawing.Point(507, 13);
            this.AI_Wins_Label.Name = "AI_Wins_Label";
            this.AI_Wins_Label.Size = new System.Drawing.Size(152, 20);
            this.AI_Wins_Label.TabIndex = 1;
            this.AI_Wins_Label.Text = "Computer Wins -0";
            // 
            // Button00
            // 
            this.Button00.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button00.Location = new System.Drawing.Point(57, 72);
            this.Button00.Name = "Button00";
            this.Button00.Size = new System.Drawing.Size(177, 160);
            this.Button00.TabIndex = 2;
            this.Button00.Tag = "play";
            this.Button00.Text = "?";
            this.Button00.UseVisualStyleBackColor = true;
            this.Button00.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button01
            // 
            this.Button01.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button01.Location = new System.Drawing.Point(251, 72);
            this.Button01.Name = "Button01";
            this.Button01.Size = new System.Drawing.Size(177, 160);
            this.Button01.TabIndex = 3;
            this.Button01.Tag = "play";
            this.Button01.Text = "?";
            this.Button01.UseVisualStyleBackColor = true;
            this.Button01.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button02
            // 
            this.Button02.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button02.Location = new System.Drawing.Point(445, 72);
            this.Button02.Name = "Button02";
            this.Button02.Size = new System.Drawing.Size(177, 160);
            this.Button02.TabIndex = 4;
            this.Button02.Tag = "play";
            this.Button02.Text = "?";
            this.Button02.UseVisualStyleBackColor = true;
            this.Button02.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button11
            // 
            this.Button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button11.Location = new System.Drawing.Point(251, 248);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(177, 160);
            this.Button11.TabIndex = 5;
            this.Button11.Tag = "play";
            this.Button11.Text = "?";
            this.Button11.UseVisualStyleBackColor = true;
            this.Button11.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button22
            // 
            this.Button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button22.Location = new System.Drawing.Point(445, 423);
            this.Button22.Name = "Button22";
            this.Button22.Size = new System.Drawing.Size(177, 160);
            this.Button22.TabIndex = 6;
            this.Button22.Tag = "play";
            this.Button22.Text = "?";
            this.Button22.UseVisualStyleBackColor = true;
            this.Button22.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button10
            // 
            this.Button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button10.Location = new System.Drawing.Point(57, 248);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(177, 160);
            this.Button10.TabIndex = 7;
            this.Button10.Tag = "play";
            this.Button10.Text = "?";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button12
            // 
            this.Button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button12.Location = new System.Drawing.Point(445, 248);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(177, 160);
            this.Button12.TabIndex = 8;
            this.Button12.Tag = "play";
            this.Button12.Text = "?";
            this.Button12.UseVisualStyleBackColor = true;
            this.Button12.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button21
            // 
            this.Button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button21.Location = new System.Drawing.Point(251, 423);
            this.Button21.Name = "Button21";
            this.Button21.Size = new System.Drawing.Size(177, 160);
            this.Button21.TabIndex = 9;
            this.Button21.Tag = "play";
            this.Button21.Text = "?";
            this.Button21.UseVisualStyleBackColor = true;
            this.Button21.Click += new System.EventHandler(this.PlayerClick);
            // 
            // Button20
            // 
            this.Button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button20.Location = new System.Drawing.Point(57, 423);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(177, 160);
            this.Button20.TabIndex = 10;
            this.Button20.Tag = "play";
            this.Button20.Text = "?";
            this.Button20.UseVisualStyleBackColor = true;
            this.Button20.Click += new System.EventHandler(this.PlayerClick);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RestartButton.Location = new System.Drawing.Point(279, 614);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(107, 31);
            this.RestartButton.TabIndex = 11;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // AImoves
            // 
            this.AImoves.Interval = 1000;
            this.AImoves.Tick += new System.EventHandler(this.AImoves_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 679);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.Button21);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button22);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.Button02);
            this.Controls.Add(this.Button01);
            this.Controls.Add(this.Button00);
            this.Controls.Add(this.AI_Wins_Label);
            this.Controls.Add(this.Player_Wins_Label);
            this.Name = "MainForm";
            this.Text = "Tic Tac Toe";
            this.Click += new System.EventHandler(this.PlayerClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player_Wins_Label;
        private System.Windows.Forms.Label AI_Wins_Label;
        private System.Windows.Forms.Button Button00;
        private System.Windows.Forms.Button Button01;
        private System.Windows.Forms.Button Button02;
        private System.Windows.Forms.Button Button11;
        private System.Windows.Forms.Button Button22;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button12;
        private System.Windows.Forms.Button Button21;
        private System.Windows.Forms.Button Button20;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Timer AImoves;
    }
}

