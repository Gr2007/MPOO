namespace Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInstr = new System.Windows.Forms.Button();
            this.btnDifficult = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.laser = new System.Windows.Forms.PictureBox();
            this.aste6 = new System.Windows.Forms.PictureBox();
            this.aste5 = new System.Windows.Forms.PictureBox();
            this.aste4 = new System.Windows.Forms.PictureBox();
            this.aste3 = new System.Windows.Forms.PictureBox();
            this.asteroide2 = new System.Windows.Forms.PictureBox();
            this.asteroide1 = new System.Windows.Forms.PictureBox();
            this.hm = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.laser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(268, 116);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInstr
            // 
            this.btnInstr.Location = new System.Drawing.Point(268, 170);
            this.btnInstr.Name = "btnInstr";
            this.btnInstr.Size = new System.Drawing.Size(103, 36);
            this.btnInstr.TabIndex = 1;
            this.btnInstr.Text = "Instructions";
            this.btnInstr.UseVisualStyleBackColor = true;
            this.btnInstr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDifficult
            // 
            this.btnDifficult.Location = new System.Drawing.Point(268, 224);
            this.btnDifficult.Name = "btnDifficult";
            this.btnDifficult.Size = new System.Drawing.Size(103, 33);
            this.btnDifficult.TabIndex = 2;
            this.btnDifficult.Text = "Difficult";
            this.btnDifficult.UseVisualStyleBackColor = true;
            this.btnDifficult.Click += new System.EventHandler(this.btnDifficult_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(268, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 31);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Exit";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // laser
            // 
            this.laser.Image = global::Proyecto.Properties.Resources.lasser1;
            this.laser.Location = new System.Drawing.Point(328, 268);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(4, 39);
            this.laser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.laser.TabIndex = 11;
            this.laser.TabStop = false;
            // 
            // aste6
            // 
            this.aste6.BackColor = System.Drawing.Color.Transparent;
            this.aste6.Image = global::Proyecto.Properties.Resources.asteroid_icon;
            this.aste6.Location = new System.Drawing.Point(12, 257);
            this.aste6.Name = "aste6";
            this.aste6.Size = new System.Drawing.Size(100, 50);
            this.aste6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aste6.TabIndex = 10;
            this.aste6.TabStop = false;
            // 
            // aste5
            // 
            this.aste5.BackColor = System.Drawing.Color.Transparent;
            this.aste5.Image = global::Proyecto.Properties.Resources._20101222063029_5025_Asteroid2;
            this.aste5.Location = new System.Drawing.Point(537, 116);
            this.aste5.Name = "aste5";
            this.aste5.Size = new System.Drawing.Size(100, 50);
            this.aste5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aste5.TabIndex = 9;
            this.aste5.TabStop = false;
            // 
            // aste4
            // 
            this.aste4.BackColor = System.Drawing.Color.Transparent;
            this.aste4.Image = global::Proyecto.Properties.Resources.asteroid_icon;
            this.aste4.Location = new System.Drawing.Point(537, 36);
            this.aste4.Name = "aste4";
            this.aste4.Size = new System.Drawing.Size(100, 50);
            this.aste4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aste4.TabIndex = 8;
            this.aste4.TabStop = false;
            // 
            // aste3
            // 
            this.aste3.BackColor = System.Drawing.Color.Transparent;
            this.aste3.Image = global::Proyecto.Properties.Resources._400px_Asteroid_Large_01;
            this.aste3.Location = new System.Drawing.Point(376, 36);
            this.aste3.Name = "aste3";
            this.aste3.Size = new System.Drawing.Size(100, 50);
            this.aste3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aste3.TabIndex = 7;
            this.aste3.TabStop = false;
            // 
            // asteroide2
            // 
            this.asteroide2.BackColor = System.Drawing.Color.Transparent;
            this.asteroide2.Image = global::Proyecto.Properties.Resources._20101222063104_5025_Asteroid4;
            this.asteroide2.Location = new System.Drawing.Point(181, 36);
            this.asteroide2.Name = "asteroide2";
            this.asteroide2.Size = new System.Drawing.Size(100, 50);
            this.asteroide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asteroide2.TabIndex = 6;
            this.asteroide2.TabStop = false;
            // 
            // asteroide1
            // 
            this.asteroide1.BackColor = System.Drawing.Color.Transparent;
            this.asteroide1.Image = global::Proyecto.Properties.Resources._20101222063029_5025_Asteroid2;
            this.asteroide1.Location = new System.Drawing.Point(33, 36);
            this.asteroide1.Name = "asteroide1";
            this.asteroide1.Size = new System.Drawing.Size(100, 50);
            this.asteroide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.asteroide1.TabIndex = 5;
            this.asteroide1.TabStop = false;
            // 
            // hm
            // 
            this.hm.BackColor = System.Drawing.Color.Transparent;
            this.hm.Image = global::Proyecto.Properties.Resources.sticker375x3601;
            this.hm.Location = new System.Drawing.Point(268, 313);
            this.hm.Name = "hm";
            this.hm.Size = new System.Drawing.Size(125, 76);
            this.hm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hm.TabIndex = 4;
            this.hm.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 592);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources._557776_star_wars_estrella_muerte_examen_ingenieria;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 392);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laser);
            this.Controls.Add(this.aste6);
            this.Controls.Add(this.aste5);
            this.Controls.Add(this.aste4);
            this.Controls.Add(this.aste3);
            this.Controls.Add(this.asteroide2);
            this.Controls.Add(this.asteroide1);
            this.Controls.Add(this.hm);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDifficult);
            this.Controls.Add(this.btnInstr);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MFGAME";
            ((System.ComponentModel.ISupportInitialize)(this.laser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aste3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInstr;
        private System.Windows.Forms.Button btnDifficult;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox hm;
        private System.Windows.Forms.PictureBox asteroide1;
        private System.Windows.Forms.PictureBox asteroide2;
        private System.Windows.Forms.PictureBox aste3;
        private System.Windows.Forms.PictureBox aste4;
        private System.Windows.Forms.PictureBox aste5;
        private System.Windows.Forms.PictureBox aste6;
        private System.Windows.Forms.PictureBox laser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

