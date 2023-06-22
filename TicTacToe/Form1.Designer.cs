namespace TicTacToe
{
    partial class TicTacToeLM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeLM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b11 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.playerL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(128, 128);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(256, 256);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(256, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.MaximumSize = new System.Drawing.Size(256, 0);
            this.label1.MinimumSize = new System.Drawing.Size(256, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tic Tac Toe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(128, 50);
            this.label2.MaximumSize = new System.Drawing.Size(256, 0);
            this.label2.MinimumSize = new System.Drawing.Size(256, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Local Multiplayer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b11
            // 
            this.b11.BackColor = System.Drawing.Color.Transparent;
            this.b11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b11.Location = new System.Drawing.Point(137, 139);
            this.b11.MaximumSize = new System.Drawing.Size(64, 64);
            this.b11.MinimumSize = new System.Drawing.Size(64, 64);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(64, 64);
            this.b11.TabIndex = 13;
            this.b11.Text = "Empty";
            this.b11.UseVisualStyleBackColor = false;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // b12
            // 
            this.b12.BackColor = System.Drawing.Color.Transparent;
            this.b12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b12.Location = new System.Drawing.Point(224, 139);
            this.b12.MaximumSize = new System.Drawing.Size(64, 64);
            this.b12.MinimumSize = new System.Drawing.Size(64, 64);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(64, 64);
            this.b12.TabIndex = 14;
            this.b12.Text = "Empty";
            this.b12.UseVisualStyleBackColor = false;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // b13
            // 
            this.b13.BackColor = System.Drawing.Color.Transparent;
            this.b13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b13.Location = new System.Drawing.Point(310, 139);
            this.b13.MaximumSize = new System.Drawing.Size(64, 64);
            this.b13.MinimumSize = new System.Drawing.Size(64, 64);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(64, 64);
            this.b13.TabIndex = 15;
            this.b13.Text = "Empty";
            this.b13.UseVisualStyleBackColor = false;
            this.b13.Click += new System.EventHandler(this.b13_Click);
            // 
            // playerL
            // 
            this.playerL.AutoSize = true;
            this.playerL.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playerL.ForeColor = System.Drawing.Color.Red;
            this.playerL.Location = new System.Drawing.Point(128, 70);
            this.playerL.MinimumSize = new System.Drawing.Size(256, 32);
            this.playerL.Name = "playerL";
            this.playerL.Size = new System.Drawing.Size(256, 41);
            this.playerL.TabIndex = 16;
            this.playerL.Text = "X";
            this.playerL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TicTacToeLM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.playerL);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(512, 512);
            this.MinimumSize = new System.Drawing.Size(512, 512);
            this.Name = "TicTacToeLM";
            this.Text = "Local Multiplater";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button b11;
        private Button b12;
        private Button b13;
        private Button button1;
        private Label playerL;
    }
}