namespace playing
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Rock Paper Scissors ";
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.White;
            this.btnRock.Location = new System.Drawing.Point(50, 100);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(180, 50);
            this.btnRock.TabIndex = 1;
            this.btnRock.Text = "Rock🎱";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnPaper.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaper.Location = new System.Drawing.Point(401, 115);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(200, 55);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Paper📃";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnScissors.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScissors.Location = new System.Drawing.Point(718, 115);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(208, 55);
            this.btnScissors.TabIndex = 3;
            this.btnScissors.Text = "Scissors✂";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.DimGray;
            this.lblResult.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(454, 264);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(113, 38);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(468, 324);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(78, 38);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0_0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNewGame.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(461, 444);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(166, 76);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Text = "New_Gim";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblPlayer.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(78, 328);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(130, 34);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "Player👤";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblComputer.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(871, 328);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(175, 34);
            this.lblComputer.TabIndex = 10;
            this.lblComputer.Text = "Computer💻";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::playing.Properties.Resources.WhatsApp_Image_2026_10_15_at_1_49_08_PM;
            this.ClientSize = new System.Drawing.Size(1163, 618);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
    }
}

