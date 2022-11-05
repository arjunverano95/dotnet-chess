namespace CHESS_GAME
{
    partial class Colors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colors));
            this.devour = new System.Windows.Forms.PictureBox();
            this.special = new System.Windows.Forms.PictureBox();
            this.selected = new System.Windows.Forms.PictureBox();
            this.regular = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.devour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.special)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regular)).BeginInit();
            this.SuspendLayout();
            // 
            // devour
            // 
            this.devour.Image = ((System.Drawing.Image)(resources.GetObject("devour.Image")));
            this.devour.Location = new System.Drawing.Point(12, 12);
            this.devour.Name = "devour";
            this.devour.Size = new System.Drawing.Size(77, 77);
            this.devour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.devour.TabIndex = 0;
            this.devour.TabStop = false;
            // 
            // special
            // 
            this.special.Image = ((System.Drawing.Image)(resources.GetObject("special.Image")));
            this.special.Location = new System.Drawing.Point(261, 12);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(77, 77);
            this.special.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.special.TabIndex = 1;
            this.special.TabStop = false;
            // 
            // selected
            // 
            this.selected.Image = ((System.Drawing.Image)(resources.GetObject("selected.Image")));
            this.selected.Location = new System.Drawing.Point(178, 12);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(77, 77);
            this.selected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.selected.TabIndex = 2;
            this.selected.TabStop = false;
            // 
            // regular
            // 
            this.regular.Image = ((System.Drawing.Image)(resources.GetObject("regular.Image")));
            this.regular.Location = new System.Drawing.Point(95, 12);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(77, 77);
            this.regular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.regular.TabIndex = 3;
            this.regular.TabStop = false;
            // 
            // Colors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 101);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.special);
            this.Controls.Add(this.devour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Colors";
            this.Text = "Colors";
            ((System.ComponentModel.ISupportInitialize)(this.devour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.special)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox devour;
        public System.Windows.Forms.PictureBox special;
        public System.Windows.Forms.PictureBox selected;
        public System.Windows.Forms.PictureBox regular;

    }
}