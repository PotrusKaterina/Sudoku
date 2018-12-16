namespace Forma.Forms
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Matrix = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.EnterAnswer = new System.Windows.Forms.Button();
            this.ToMainMenu = new System.Windows.Forms.Button();
            this.ResartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Matrix
            // 
            this.Matrix.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matrix.Location = new System.Drawing.Point(34, 23);
            this.Matrix.Multiline = true;
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(281, 324);
            this.Matrix.TabIndex = 0;
            this.Matrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Matrix.TextChanged += new System.EventHandler(this.Matrix_TextChanged);
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.White;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Restart.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.ForeColor = System.Drawing.Color.Crimson;
            this.Restart.Location = new System.Drawing.Point(371, 24);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(168, 57);
            this.Restart.TabIndex = 0;
            this.Restart.Text = "New game";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // EnterAnswer
            // 
            this.EnterAnswer.BackColor = System.Drawing.Color.White;
            this.EnterAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterAnswer.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAnswer.ForeColor = System.Drawing.Color.Crimson;
            this.EnterAnswer.Location = new System.Drawing.Point(371, 150);
            this.EnterAnswer.Name = "EnterAnswer";
            this.EnterAnswer.Size = new System.Drawing.Size(168, 57);
            this.EnterAnswer.TabIndex = 1;
            this.EnterAnswer.Text = "Enter answer";
            this.EnterAnswer.UseVisualStyleBackColor = false;
            this.EnterAnswer.Click += new System.EventHandler(this.EnterAnswer_Click);
            this.EnterAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterAnswer_KeyPress);
            // 
            // ToMainMenu
            // 
            this.ToMainMenu.BackColor = System.Drawing.Color.White;
            this.ToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ToMainMenu.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMainMenu.ForeColor = System.Drawing.Color.Crimson;
            this.ToMainMenu.Location = new System.Drawing.Point(371, 290);
            this.ToMainMenu.Name = "ToMainMenu";
            this.ToMainMenu.Size = new System.Drawing.Size(168, 57);
            this.ToMainMenu.TabIndex = 2;
            this.ToMainMenu.Text = "Main menu";
            this.ToMainMenu.UseVisualStyleBackColor = false;
            this.ToMainMenu.Click += new System.EventHandler(this.ToMainMenu_Click);
            // 
            // ResartGame
            // 
            this.ResartGame.BackColor = System.Drawing.Color.White;
            this.ResartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResartGame.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResartGame.ForeColor = System.Drawing.Color.Crimson;
            this.ResartGame.Location = new System.Drawing.Point(371, 87);
            this.ResartGame.Name = "ResartGame";
            this.ResartGame.Size = new System.Drawing.Size(168, 57);
            this.ResartGame.TabIndex = 3;
            this.ResartGame.Text = "Restart";
            this.ResartGame.UseVisualStyleBackColor = false;
            this.ResartGame.Click += new System.EventHandler(this.ResartGame_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(596, 396);
            this.Controls.Add(this.ResartGame);
            this.Controls.Add(this.ToMainMenu);
            this.Controls.Add(this.EnterAnswer);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Matrix);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Matrix;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button EnterAnswer;
        private System.Windows.Forms.Button ToMainMenu;
        private System.Windows.Forms.Button ResartGame;
    }
}