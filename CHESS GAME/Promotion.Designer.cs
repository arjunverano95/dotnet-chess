namespace CHESS_GAME
{
    partial class Promotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promotion));
            this.label1 = new System.Windows.Forms.Label();
            this.w_queen = new System.Windows.Forms.RadioButton();
            this.w_bishop = new System.Windows.Forms.RadioButton();
            this.w_knight = new System.Windows.Forms.RadioButton();
            this.w_rook = new System.Windows.Forms.RadioButton();
            this.w_queenicon = new System.Windows.Forms.PictureBox();
            this.w_bishopicon = new System.Windows.Forms.PictureBox();
            this.w_knighticon = new System.Windows.Forms.PictureBox();
            this.w_rookicon = new System.Windows.Forms.PictureBox();
            this.btnPromote = new System.Windows.Forms.Button();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.pnlBlack = new System.Windows.Forms.Panel();
            this.b_queenicon = new System.Windows.Forms.PictureBox();
            this.b_queen = new System.Windows.Forms.RadioButton();
            this.b_rookicon = new System.Windows.Forms.PictureBox();
            this.b_bishop = new System.Windows.Forms.RadioButton();
            this.b_knighticon = new System.Windows.Forms.PictureBox();
            this.b_knight = new System.Windows.Forms.RadioButton();
            this.b_bishopicon = new System.Windows.Forms.PictureBox();
            this.b_rook = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.w_queenicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_bishopicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_knighticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_rookicon)).BeginInit();
            this.pnlWhite.SuspendLayout();
            this.pnlBlack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_queenicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_rookicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_knighticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_bishopicon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROMOTE TO: ";
            // 
            // w_queen
            // 
            this.w_queen.AutoSize = true;
            this.w_queen.Location = new System.Drawing.Point(5, 34);
            this.w_queen.Name = "w_queen";
            this.w_queen.Size = new System.Drawing.Size(14, 13);
            this.w_queen.TabIndex = 0;
            this.w_queen.TabStop = true;
            this.w_queen.UseVisualStyleBackColor = true;
            this.w_queen.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // w_bishop
            // 
            this.w_bishop.AutoSize = true;
            this.w_bishop.Location = new System.Drawing.Point(100, 34);
            this.w_bishop.Name = "w_bishop";
            this.w_bishop.Size = new System.Drawing.Size(14, 13);
            this.w_bishop.TabIndex = 1;
            this.w_bishop.TabStop = true;
            this.w_bishop.UseVisualStyleBackColor = true;
            this.w_bishop.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // w_knight
            // 
            this.w_knight.AutoSize = true;
            this.w_knight.Location = new System.Drawing.Point(195, 34);
            this.w_knight.Name = "w_knight";
            this.w_knight.Size = new System.Drawing.Size(14, 13);
            this.w_knight.TabIndex = 2;
            this.w_knight.TabStop = true;
            this.w_knight.UseVisualStyleBackColor = true;
            this.w_knight.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // w_rook
            // 
            this.w_rook.AutoSize = true;
            this.w_rook.Location = new System.Drawing.Point(290, 34);
            this.w_rook.Name = "w_rook";
            this.w_rook.Size = new System.Drawing.Size(14, 13);
            this.w_rook.TabIndex = 3;
            this.w_rook.TabStop = true;
            this.w_rook.UseVisualStyleBackColor = true;
            this.w_rook.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // w_queenicon
            // 
            this.w_queenicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w_queenicon.BackgroundImage")));
            this.w_queenicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w_queenicon.Location = new System.Drawing.Point(25, 10);
            this.w_queenicon.Name = "w_queenicon";
            this.w_queenicon.Size = new System.Drawing.Size(60, 60);
            this.w_queenicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w_queenicon.TabIndex = 4;
            this.w_queenicon.TabStop = false;
            // 
            // w_bishopicon
            // 
            this.w_bishopicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w_bishopicon.BackgroundImage")));
            this.w_bishopicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w_bishopicon.Location = new System.Drawing.Point(120, 10);
            this.w_bishopicon.Name = "w_bishopicon";
            this.w_bishopicon.Size = new System.Drawing.Size(60, 60);
            this.w_bishopicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w_bishopicon.TabIndex = 5;
            this.w_bishopicon.TabStop = false;
            // 
            // w_knighticon
            // 
            this.w_knighticon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w_knighticon.BackgroundImage")));
            this.w_knighticon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w_knighticon.Location = new System.Drawing.Point(215, 10);
            this.w_knighticon.Name = "w_knighticon";
            this.w_knighticon.Size = new System.Drawing.Size(60, 60);
            this.w_knighticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w_knighticon.TabIndex = 6;
            this.w_knighticon.TabStop = false;
            // 
            // w_rookicon
            // 
            this.w_rookicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("w_rookicon.BackgroundImage")));
            this.w_rookicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w_rookicon.Location = new System.Drawing.Point(310, 10);
            this.w_rookicon.Name = "w_rookicon";
            this.w_rookicon.Size = new System.Drawing.Size(60, 60);
            this.w_rookicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w_rookicon.TabIndex = 7;
            this.w_rookicon.TabStop = false;
            // 
            // btnPromote
            // 
            this.btnPromote.Location = new System.Drawing.Point(324, 154);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Size = new System.Drawing.Size(90, 26);
            this.btnPromote.TabIndex = 8;
            this.btnPromote.Text = "PROMOTE";
            this.btnPromote.UseVisualStyleBackColor = true;
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // pnlWhite
            // 
            this.pnlWhite.Controls.Add(this.w_queenicon);
            this.pnlWhite.Controls.Add(this.w_queen);
            this.pnlWhite.Controls.Add(this.w_rookicon);
            this.pnlWhite.Controls.Add(this.w_bishop);
            this.pnlWhite.Controls.Add(this.w_knighticon);
            this.pnlWhite.Controls.Add(this.w_knight);
            this.pnlWhite.Controls.Add(this.w_bishopicon);
            this.pnlWhite.Controls.Add(this.w_rook);
            this.pnlWhite.Location = new System.Drawing.Point(35, 57);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(379, 76);
            this.pnlWhite.TabIndex = 9;
            this.pnlWhite.Visible = false;
            // 
            // pnlBlack
            // 
            this.pnlBlack.Controls.Add(this.b_queenicon);
            this.pnlBlack.Controls.Add(this.b_queen);
            this.pnlBlack.Controls.Add(this.b_rookicon);
            this.pnlBlack.Controls.Add(this.b_bishop);
            this.pnlBlack.Controls.Add(this.b_knighticon);
            this.pnlBlack.Controls.Add(this.b_knight);
            this.pnlBlack.Controls.Add(this.b_bishopicon);
            this.pnlBlack.Controls.Add(this.b_rook);
            this.pnlBlack.Location = new System.Drawing.Point(35, 57);
            this.pnlBlack.Name = "pnlBlack";
            this.pnlBlack.Size = new System.Drawing.Size(379, 76);
            this.pnlBlack.TabIndex = 10;
            this.pnlBlack.Visible = false;
            // 
            // b_queenicon
            // 
            this.b_queenicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_queenicon.BackgroundImage")));
            this.b_queenicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_queenicon.Location = new System.Drawing.Point(25, 10);
            this.b_queenicon.Name = "b_queenicon";
            this.b_queenicon.Size = new System.Drawing.Size(60, 60);
            this.b_queenicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_queenicon.TabIndex = 4;
            this.b_queenicon.TabStop = false;
            // 
            // b_queen
            // 
            this.b_queen.AutoSize = true;
            this.b_queen.Location = new System.Drawing.Point(5, 34);
            this.b_queen.Name = "b_queen";
            this.b_queen.Size = new System.Drawing.Size(14, 13);
            this.b_queen.TabIndex = 0;
            this.b_queen.TabStop = true;
            this.b_queen.UseVisualStyleBackColor = true;
            this.b_queen.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // b_rookicon
            // 
            this.b_rookicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_rookicon.BackgroundImage")));
            this.b_rookicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_rookicon.Location = new System.Drawing.Point(310, 10);
            this.b_rookicon.Name = "b_rookicon";
            this.b_rookicon.Size = new System.Drawing.Size(60, 60);
            this.b_rookicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_rookicon.TabIndex = 7;
            this.b_rookicon.TabStop = false;
            // 
            // b_bishop
            // 
            this.b_bishop.AutoSize = true;
            this.b_bishop.Location = new System.Drawing.Point(100, 34);
            this.b_bishop.Name = "b_bishop";
            this.b_bishop.Size = new System.Drawing.Size(14, 13);
            this.b_bishop.TabIndex = 1;
            this.b_bishop.TabStop = true;
            this.b_bishop.UseVisualStyleBackColor = true;
            this.b_bishop.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // b_knighticon
            // 
            this.b_knighticon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_knighticon.BackgroundImage")));
            this.b_knighticon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_knighticon.Location = new System.Drawing.Point(215, 10);
            this.b_knighticon.Name = "b_knighticon";
            this.b_knighticon.Size = new System.Drawing.Size(60, 60);
            this.b_knighticon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_knighticon.TabIndex = 6;
            this.b_knighticon.TabStop = false;
            // 
            // b_knight
            // 
            this.b_knight.AutoSize = true;
            this.b_knight.Location = new System.Drawing.Point(195, 34);
            this.b_knight.Name = "b_knight";
            this.b_knight.Size = new System.Drawing.Size(14, 13);
            this.b_knight.TabIndex = 2;
            this.b_knight.TabStop = true;
            this.b_knight.UseVisualStyleBackColor = true;
            this.b_knight.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // b_bishopicon
            // 
            this.b_bishopicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_bishopicon.BackgroundImage")));
            this.b_bishopicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_bishopicon.Location = new System.Drawing.Point(120, 10);
            this.b_bishopicon.Name = "b_bishopicon";
            this.b_bishopicon.Size = new System.Drawing.Size(60, 60);
            this.b_bishopicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b_bishopicon.TabIndex = 5;
            this.b_bishopicon.TabStop = false;
            // 
            // b_rook
            // 
            this.b_rook.AutoSize = true;
            this.b_rook.Location = new System.Drawing.Point(290, 34);
            this.b_rook.Name = "b_rook";
            this.b_rook.Size = new System.Drawing.Size(14, 13);
            this.b_rook.TabIndex = 3;
            this.b_rook.TabStop = true;
            this.b_rook.UseVisualStyleBackColor = true;
            this.b_rook.CheckedChanged += new System.EventHandler(this.w_rook_CheckedChanged);
            // 
            // Promotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 215);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlWhite);
            this.Controls.Add(this.pnlBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Promotion";
            this.Text = "Promotion";
            this.Load += new System.EventHandler(this.Promotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.w_queenicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_bishopicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_knighticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w_rookicon)).EndInit();
            this.pnlWhite.ResumeLayout(false);
            this.pnlWhite.PerformLayout();
            this.pnlBlack.ResumeLayout(false);
            this.pnlBlack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b_queenicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_rookicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_knighticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_bishopicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton w_queen;
        private System.Windows.Forms.RadioButton w_bishop;
        private System.Windows.Forms.RadioButton w_knight;
        private System.Windows.Forms.RadioButton w_rook;
        private System.Windows.Forms.PictureBox w_queenicon;
        private System.Windows.Forms.PictureBox w_bishopicon;
        private System.Windows.Forms.PictureBox w_knighticon;
        private System.Windows.Forms.PictureBox w_rookicon;
        private System.Windows.Forms.Button btnPromote;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Panel pnlBlack;
        private System.Windows.Forms.PictureBox b_queenicon;
        private System.Windows.Forms.RadioButton b_queen;
        private System.Windows.Forms.PictureBox b_rookicon;
        private System.Windows.Forms.RadioButton b_bishop;
        private System.Windows.Forms.PictureBox b_knighticon;
        private System.Windows.Forms.RadioButton b_knight;
        private System.Windows.Forms.PictureBox b_bishopicon;
        private System.Windows.Forms.RadioButton b_rook;
    }
}