namespace Organizer
{
    partial class UI_View
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.richtextBoxReview = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxCreator = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(627, 467);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(125, 32);
            this.buttonEdit.TabIndex = 31;
            this.buttonEdit.Text = "Edit ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // richtextBoxReview
            // 
            this.richtextBoxReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richtextBoxReview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextBoxReview.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richtextBoxReview.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.richtextBoxReview.Location = new System.Drawing.Point(152, 392);
            this.richtextBoxReview.Name = "richtextBoxReview";
            this.richtextBoxReview.ReadOnly = true;
            this.richtextBoxReview.Size = new System.Drawing.Size(358, 90);
            this.richtextBoxReview.TabIndex = 30;
            this.richtextBoxReview.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(48, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Review";
            // 
            // textBoxRate
            // 
            this.textBoxRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRate.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRate.Location = new System.Drawing.Point(152, 344);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(175, 23);
            this.textBoxRate.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(49, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rate";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenre.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxGenre.Location = new System.Drawing.Point(152, 294);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ReadOnly = true;
            this.textBoxGenre.Size = new System.Drawing.Size(175, 23);
            this.textBoxGenre.TabIndex = 21;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.labelGenre.Location = new System.Drawing.Point(48, 294);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(62, 23);
            this.labelGenre.TabIndex = 26;
            this.labelGenre.Text = "Genre";
            // 
            // textBoxCreator
            // 
            this.textBoxCreator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCreator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCreator.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCreator.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCreator.Location = new System.Drawing.Point(52, 236);
            this.textBoxCreator.Name = "textBoxCreator";
            this.textBoxCreator.ReadOnly = true;
            this.textBoxCreator.Size = new System.Drawing.Size(296, 25);
            this.textBoxCreator.TabIndex = 25;
            this.textBoxCreator.Text = "Creator";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxTitle.Location = new System.Drawing.Point(52, 201);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(310, 29);
            this.textBoxTitle.TabIndex = 24;
            this.textBoxTitle.Text = "Title";
            // 
            // textBoxFile
            // 
            this.textBoxFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFile.Enabled = false;
            this.textBoxFile.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxFile.Location = new System.Drawing.Point(53, 162);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(309, 19);
            this.textBoxFile.TabIndex = 23;
            this.textBoxFile.Text = "Click the image for path";
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBook.Enabled = false;
            this.pictureBoxBook.Location = new System.Drawing.Point(53, 16);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(153, 140);
            this.pictureBoxBook.TabIndex = 22;
            this.pictureBoxBook.TabStop = false;
            // 
            // UI_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.richtextBoxReview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textBoxCreator);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.pictureBoxBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UI_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI_View";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_View_FormClosed);
            this.Load += new System.EventHandler(this.UI_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.RichTextBox richtextBoxReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxCreator;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.PictureBox pictureBoxBook;
    }
}