namespace game
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
            this.btAgain = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTrai = new System.Windows.Forms.Button();
            this.btPhai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAgain
            // 
            this.btAgain.Location = new System.Drawing.Point(263, 265);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(187, 23);
            this.btAgain.TabIndex = 0;
            this.btAgain.Text = "Again";
            this.btAgain.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(263, 318);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(187, 23);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoat";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btTrai
            // 
            this.btTrai.Location = new System.Drawing.Point(145, 380);
            this.btTrai.Name = "btTrai";
            this.btTrai.Size = new System.Drawing.Size(75, 23);
            this.btTrai.TabIndex = 3;
            this.btTrai.Text = "Trái";
            this.btTrai.UseVisualStyleBackColor = true;
            this.btTrai.Click += new System.EventHandler(this.btTrai_Click);
            // 
            // btPhai
            // 
            this.btPhai.Location = new System.Drawing.Point(531, 380);
            this.btPhai.Name = "btPhai";
            this.btPhai.Size = new System.Drawing.Size(75, 23);
            this.btPhai.TabIndex = 4;
            this.btPhai.Text = "Phải";
            this.btPhai.UseVisualStyleBackColor = true;
            this.btPhai.Click += new System.EventHandler(this.btPhai_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPhai);
            this.Controls.Add(this.btTrai);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btAgain);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAgain;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTrai;
        private System.Windows.Forms.Button btPhai;
    }
}