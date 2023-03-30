namespace Organizer
{
    partial class UI_HomePage
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxShows = new System.Windows.Forms.PictureBox();
            this.pictureBoxMovies = new System.Windows.Forms.PictureBox();
            this.pictureBoxBooks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(638, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(98, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Movies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(244, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Where are you heading?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(374, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Books";
            // 
            // pictureBoxShows
            // 
            this.pictureBoxShows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxShows.Location = new System.Drawing.Point(581, 209);
            this.pictureBoxShows.Name = "pictureBoxShows";
            this.pictureBoxShows.Size = new System.Drawing.Size(169, 122);
            this.pictureBoxShows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShows.TabIndex = 11;
            this.pictureBoxShows.TabStop = false;
            this.pictureBoxShows.DoubleClick += new System.EventHandler(this.pictureBoxShows_DoubleClick);
            // 
            // pictureBoxMovies
            // 
            this.pictureBoxMovies.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxMovies.Location = new System.Drawing.Point(51, 209);
            this.pictureBoxMovies.Name = "pictureBoxMovies";
            this.pictureBoxMovies.Size = new System.Drawing.Size(169, 122);
            this.pictureBoxMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMovies.TabIndex = 10;
            this.pictureBoxMovies.TabStop = false;
            this.pictureBoxMovies.DoubleClick += new System.EventHandler(this.pictureBoxMovies_DoubleClick);
            // 
            // pictureBoxBooks
            // 
            this.pictureBoxBooks.Location = new System.Drawing.Point(318, 209);
            this.pictureBoxBooks.Name = "pictureBoxBooks";
            this.pictureBoxBooks.Size = new System.Drawing.Size(169, 122);
            this.pictureBoxBooks.TabIndex = 7;
            this.pictureBoxBooks.TabStop = false;
            this.pictureBoxBooks.DoubleClick += new System.EventHandler(this.pictureBoxBooks_DoubleClick);
            // 
            // UI_HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxShows);
            this.Controls.Add(this.pictureBoxMovies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UI_HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI_HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_HomePage_FormClosed);
            this.Load += new System.EventHandler(this.UI_HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxShows;
        private System.Windows.Forms.PictureBox pictureBoxMovies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBooks;
    }
}