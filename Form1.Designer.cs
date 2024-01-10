
namespace Sweng421_Lab01_version1
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
            this.Control_pnl = new System.Windows.Forms.Panel();
            this.track_blu = new System.Windows.Forms.TrackBar();
            this.Track_grn = new System.Windows.Forms.TrackBar();
            this.Track_red = new System.Windows.Forms.TrackBar();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_free = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ell = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_panel = new System.Windows.Forms.PictureBox();
            this.Control_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_blu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_grn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_pnl
            // 
            this.Control_pnl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Control_pnl.Controls.Add(this.track_blu);
            this.Control_pnl.Controls.Add(this.Track_grn);
            this.Control_pnl.Controls.Add(this.Track_red);
            this.Control_pnl.Controls.Add(this.btn_erase);
            this.Control_pnl.Controls.Add(this.btn_free);
            this.Control_pnl.Controls.Add(this.btn_rect);
            this.Control_pnl.Controls.Add(this.btn_ell);
            this.Control_pnl.Controls.Add(this.btn_line);
            this.Control_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_pnl.Location = new System.Drawing.Point(0, 0);
            this.Control_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.Control_pnl.Name = "Control_pnl";
            this.Control_pnl.Size = new System.Drawing.Size(686, 77);
            this.Control_pnl.TabIndex = 0;
            // 
            // track_blu
            // 
            this.track_blu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.track_blu.AutoSize = false;
            this.track_blu.BackColor = System.Drawing.Color.Blue;
            this.track_blu.Location = new System.Drawing.Point(532, 15);
            this.track_blu.Margin = new System.Windows.Forms.Padding(2);
            this.track_blu.Maximum = 255;
            this.track_blu.Name = "track_blu";
            this.track_blu.Size = new System.Drawing.Size(116, 47);
            this.track_blu.TabIndex = 4;
            this.track_blu.Value = 100;
            this.track_blu.Scroll += new System.EventHandler(this.track_blu_Scroll);
            // 
            // Track_grn
            // 
            this.Track_grn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Track_grn.BackColor = System.Drawing.Color.Green;
            this.Track_grn.Location = new System.Drawing.Point(395, 15);
            this.Track_grn.Margin = new System.Windows.Forms.Padding(2);
            this.Track_grn.Maximum = 255;
            this.Track_grn.Name = "Track_grn";
            this.Track_grn.Size = new System.Drawing.Size(120, 45);
            this.Track_grn.TabIndex = 3;
            this.Track_grn.Value = 100;
            this.Track_grn.Scroll += new System.EventHandler(this.Track_grn_Scroll);
            // 
            // Track_red
            // 
            this.Track_red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Track_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Track_red.Location = new System.Drawing.Point(252, 15);
            this.Track_red.Margin = new System.Windows.Forms.Padding(2);
            this.Track_red.Maximum = 255;
            this.Track_red.Name = "Track_red";
            this.Track_red.Size = new System.Drawing.Size(125, 45);
            this.Track_red.TabIndex = 0;
            this.Track_red.Value = 100;
            this.Track_red.Scroll += new System.EventHandler(this.Track_red_Scroll);
            // 
            // btn_erase
            // 
            this.btn_erase.Location = new System.Drawing.Point(138, 46);
            this.btn_erase.Margin = new System.Windows.Forms.Padding(2);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(62, 21);
            this.btn_erase.TabIndex = 1;
            this.btn_erase.Text = "Erase";
            this.btn_erase.UseVisualStyleBackColor = true;
            this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
            // 
            // btn_free
            // 
            this.btn_free.Location = new System.Drawing.Point(54, 46);
            this.btn_free.Margin = new System.Windows.Forms.Padding(2);
            this.btn_free.Name = "btn_free";
            this.btn_free.Size = new System.Drawing.Size(62, 21);
            this.btn_free.TabIndex = 2;
            this.btn_free.Text = "Free";
            this.btn_free.UseVisualStyleBackColor = true;
            this.btn_free.Click += new System.EventHandler(this.btn_free_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Location = new System.Drawing.Point(174, 15);
            this.btn_rect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(62, 21);
            this.btn_rect.TabIndex = 1;
            this.btn_rect.Text = "Rect";
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_ell
            // 
            this.btn_ell.Location = new System.Drawing.Point(96, 15);
            this.btn_ell.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ell.Name = "btn_ell";
            this.btn_ell.Size = new System.Drawing.Size(62, 21);
            this.btn_ell.TabIndex = 1;
            this.btn_ell.Text = "Ellipse";
            this.btn_ell.UseVisualStyleBackColor = true;
            this.btn_ell.Click += new System.EventHandler(this.btn_ell_Click);
            // 
            // btn_line
            // 
            this.btn_line.Location = new System.Drawing.Point(14, 15);
            this.btn_line.Margin = new System.Windows.Forms.Padding(2);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(62, 21);
            this.btn_line.TabIndex = 0;
            this.btn_line.Text = "Line";
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 376);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 17);
            this.panel1.TabIndex = 2;
            // 
            // pic_panel
            // 
            this.pic_panel.BackColor = System.Drawing.Color.White;
            this.pic_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_panel.Location = new System.Drawing.Point(0, 77);
            this.pic_panel.Name = "pic_panel";
            this.pic_panel.Size = new System.Drawing.Size(686, 299);
            this.pic_panel.TabIndex = 0;
            this.pic_panel.TabStop = false;
            this.pic_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_panel_MouseDown);
            this.pic_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_panel_MouseMove);
            this.pic_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_panel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 393);
            this.Controls.Add(this.pic_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Control_pnl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Control_pnl.ResumeLayout(false);
            this.Control_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_blu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_grn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_pnl;
        private System.Windows.Forms.TrackBar track_blu;
        private System.Windows.Forms.TrackBar Track_grn;
        private System.Windows.Forms.TrackBar Track_red;
        private System.Windows.Forms.Button btn_erase;
        private System.Windows.Forms.Button btn_free;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ell;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_panel;
    }
}

