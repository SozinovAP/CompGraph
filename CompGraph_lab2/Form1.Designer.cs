namespace CompGraph_lab2
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
            this.glControl1 = new OpenTK.GLControl();
            this.button3 = new System.Windows.Forms.Button();
            this.LayerTomo = new System.Windows.Forms.TrackBar();
            this.QuadsV = new System.Windows.Forms.RadioButton();
            this.TextureV = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.LayerTomo)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(-22, 55);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(826, 337);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Загрузить томограмму";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LayerTomo
            // 
            this.LayerTomo.Location = new System.Drawing.Point(26, 4);
            this.LayerTomo.Name = "LayerTomo";
            this.LayerTomo.Size = new System.Drawing.Size(762, 45);
            this.LayerTomo.TabIndex = 4;
            this.LayerTomo.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // QuadsV
            // 
            this.QuadsV.AutoSize = true;
            this.QuadsV.Checked = true;
            this.QuadsV.Location = new System.Drawing.Point(702, 4);
            this.QuadsV.Name = "QuadsV";
            this.QuadsV.Size = new System.Drawing.Size(56, 17);
            this.QuadsV.TabIndex = 5;
            this.QuadsV.TabStop = true;
            this.QuadsV.Text = "Quads";
            this.QuadsV.UseVisualStyleBackColor = true;
            // 
            // TextureV
            // 
            this.TextureV.AutoSize = true;
            this.TextureV.Location = new System.Drawing.Point(702, 28);
            this.TextureV.Name = "TextureV";
            this.TextureV.Size = new System.Drawing.Size(61, 17);
            this.TextureV.TabIndex = 6;
            this.TextureV.TabStop = true;
            this.TextureV.Text = "Texture";
            this.TextureV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextureV);
            this.Controls.Add(this.QuadsV);
            this.Controls.Add(this.LayerTomo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayerTomo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar LayerTomo;
        private System.Windows.Forms.RadioButton QuadsV;
        private System.Windows.Forms.RadioButton TextureV;
    }
}

