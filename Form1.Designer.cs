namespace howto_draw_normal_distribution
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.picGraph2 = new System.Windows.Forms.PictureBox();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.lmovie = new System.Windows.Forms.Label();
            this.lserie = new System.Windows.Forms.Label();
            this.tbrandom = new System.Windows.Forms.TextBox();
            this.sm = new System.Windows.Forms.Label();
            this.ns = new System.Windows.Forms.Label();
            this.st = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // picGraph2
            // 
            this.picGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGraph2.BackColor = System.Drawing.Color.White;
            this.picGraph2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraph2.Location = new System.Drawing.Point(258, 75);
            this.picGraph2.Name = "picGraph2";
            this.picGraph2.Size = new System.Drawing.Size(257, 271);
            this.picGraph2.TabIndex = 8;
            this.picGraph2.TabStop = false;
            // 
            // picGraph
            // 
            this.picGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGraph.BackColor = System.Drawing.Color.White;
            this.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraph.Location = new System.Drawing.Point(2, 75);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(257, 271);
            this.picGraph.TabIndex = 7;
            this.picGraph.TabStop = false;
            // 
            // lmovie
            // 
            this.lmovie.AutoSize = true;
            this.lmovie.Location = new System.Drawing.Point(23, 59);
            this.lmovie.Name = "lmovie";
            this.lmovie.Size = new System.Drawing.Size(36, 13);
            this.lmovie.TabIndex = 9;
            this.lmovie.Text = "Movie";
            // 
            // lserie
            // 
            this.lserie.AutoSize = true;
            this.lserie.Location = new System.Drawing.Point(291, 59);
            this.lserie.Name = "lserie";
            this.lserie.Size = new System.Drawing.Size(31, 13);
            this.lserie.TabIndex = 10;
            this.lserie.Text = "Serie";
            // 
            // tbrandom
            // 
            this.tbrandom.Location = new System.Drawing.Point(93, 15);
            this.tbrandom.Name = "tbrandom";
            this.tbrandom.Size = new System.Drawing.Size(124, 20);
            this.tbrandom.TabIndex = 11;
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.Location = new System.Drawing.Point(223, 21);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(107, 13);
            this.sm.TabIndex = 12;
            this.sm.Text = "Serie duracion Mayor";
            // 
            // ns
            // 
            this.ns.AutoSize = true;
            this.ns.Location = new System.Drawing.Point(377, 46);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(89, 13);
            this.ns.TabIndex = 13;
            this.ns.Text = "Numero de series";
            // 
            // st
            // 
            this.st.AutoSize = true;
            this.st.Location = new System.Drawing.Point(363, 22);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(103, 13);
            this.st.TabIndex = 14;
            this.st.Text = "Series duracion total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDraw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.st);
            this.Controls.Add(this.ns);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.tbrandom);
            this.Controls.Add(this.lserie);
            this.Controls.Add(this.lmovie);
            this.Controls.Add(this.picGraph2);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.btnDraw);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "howto_draw_normal_distribution";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox picGraph2;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.Label lmovie;
        private System.Windows.Forms.Label lserie;
        private System.Windows.Forms.TextBox tbrandom;
        private System.Windows.Forms.Label sm;
        private System.Windows.Forms.Label ns;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.Label label1;
    }
}

