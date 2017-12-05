namespace Proyecto
{
    partial class Form4
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
            this.rdbfacil = new System.Windows.Forms.RadioButton();
            this.rdbmedia = new System.Windows.Forms.RadioButton();
            this.rdbdificil = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbfacil
            // 
            this.rdbfacil.AutoSize = true;
            this.rdbfacil.BackColor = System.Drawing.Color.RosyBrown;
            this.rdbfacil.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfacil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbfacil.Location = new System.Drawing.Point(12, 57);
            this.rdbfacil.Name = "rdbfacil";
            this.rdbfacil.Size = new System.Drawing.Size(72, 28);
            this.rdbfacil.TabIndex = 0;
            this.rdbfacil.TabStop = true;
            this.rdbfacil.Text = "Fácil";
            this.rdbfacil.UseVisualStyleBackColor = false;
            // 
            // rdbmedia
            // 
            this.rdbmedia.AutoSize = true;
            this.rdbmedia.BackColor = System.Drawing.Color.DarkCyan;
            this.rdbmedia.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmedia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbmedia.Location = new System.Drawing.Point(12, 97);
            this.rdbmedia.Name = "rdbmedia";
            this.rdbmedia.Size = new System.Drawing.Size(89, 28);
            this.rdbmedia.TabIndex = 1;
            this.rdbmedia.TabStop = true;
            this.rdbmedia.Text = "Media";
            this.rdbmedia.UseVisualStyleBackColor = false;
            // 
            // rdbdificil
            // 
            this.rdbdificil.AutoSize = true;
            this.rdbdificil.BackColor = System.Drawing.SystemColors.Highlight;
            this.rdbdificil.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdificil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbdificil.Location = new System.Drawing.Point(12, 139);
            this.rdbdificil.Name = "rdbdificil";
            this.rdbdificil.Size = new System.Drawing.Size(85, 28);
            this.rdbdificil.TabIndex = 2;
            this.rdbdificil.TabStop = true;
            this.rdbdificil.Text = "Difícil";
            this.rdbdificil.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dificultad:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.star_wars_episode_iv_chewbacca_han_solo_gq6k;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbdificil);
            this.Controls.Add(this.rdbmedia);
            this.Controls.Add(this.rdbfacil);
            this.Name = "Form4";
            this.Text = "Dificultad";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbfacil;
        private System.Windows.Forms.RadioButton rdbmedia;
        private System.Windows.Forms.RadioButton rdbdificil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}