namespace Educapp
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnRaia = new System.Windows.Forms.Panel();
            this.pbObstaculo2 = new System.Windows.Forms.PictureBox();
            this.pbObstaculo = new System.Windows.Forms.PictureBox();
            this.pbPersonagem = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lbLose = new System.Windows.Forms.Label();
            this.tmPontuacao = new System.Windows.Forms.Timer(this.components);
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblConsolacao = new System.Windows.Forms.Label();
            this.pnRaia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstaculo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstaculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnRaia
            // 
            this.pnRaia.BackgroundImage = global::Educapp.Properties.Resources.raia;
            this.pnRaia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnRaia.Controls.Add(this.pbObstaculo2);
            this.pnRaia.Controls.Add(this.pbObstaculo);
            this.pnRaia.Controls.Add(this.pbPersonagem);
            this.pnRaia.Location = new System.Drawing.Point(335, 33);
            this.pnRaia.Name = "pnRaia";
            this.pnRaia.Size = new System.Drawing.Size(260, 460);
            this.pnRaia.TabIndex = 0;
            // 
            // pbObstaculo2
            // 
            this.pbObstaculo2.BackColor = System.Drawing.Color.Transparent;
            this.pbObstaculo2.BackgroundImage = global::Educapp.Properties.Resources.obstaculo;
            this.pbObstaculo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbObstaculo2.Location = new System.Drawing.Point(9, 460);
            this.pbObstaculo2.Name = "pbObstaculo2";
            this.pbObstaculo2.Size = new System.Drawing.Size(73, 41);
            this.pbObstaculo2.TabIndex = 4;
            this.pbObstaculo2.TabStop = false;
            // 
            // pbObstaculo
            // 
            this.pbObstaculo.BackColor = System.Drawing.Color.Transparent;
            this.pbObstaculo.BackgroundImage = global::Educapp.Properties.Resources.obstaculo;
            this.pbObstaculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbObstaculo.ErrorImage = null;
            this.pbObstaculo.Location = new System.Drawing.Point(94, 460);
            this.pbObstaculo.Name = "pbObstaculo";
            this.pbObstaculo.Size = new System.Drawing.Size(73, 41);
            this.pbObstaculo.TabIndex = 3;
            this.pbObstaculo.TabStop = false;
            // 
            // pbPersonagem
            // 
            this.pbPersonagem.BackColor = System.Drawing.Color.Transparent;
            this.pbPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonagem.Image")));
            this.pbPersonagem.InitialImage = null;
            this.pbPersonagem.Location = new System.Drawing.Point(94, 15);
            this.pbPersonagem.Name = "pbPersonagem";
            this.pbPersonagem.Size = new System.Drawing.Size(73, 69);
            this.pbPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPersonagem.TabIndex = 2;
            this.pbPersonagem.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 10;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(523, 366);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(219, 71);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Visible = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.White;
            this.btnReiniciar.FlatAppearance.BorderSize = 10;
            this.btnReiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(184, 366);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(219, 71);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lbLose
            // 
            this.lbLose.AutoSize = true;
            this.lbLose.BackColor = System.Drawing.Color.Transparent;
            this.lbLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLose.Location = new System.Drawing.Point(195, 146);
            this.lbLose.Name = "lbLose";
            this.lbLose.Size = new System.Drawing.Size(530, 108);
            this.lbLose.TabIndex = 8;
            this.lbLose.Text = "YOU LOST";
            this.lbLose.Visible = false;
            // 
            // tmPontuacao
            // 
            this.tmPontuacao.Enabled = true;
            this.tmPontuacao.Interval = 1000;
            this.tmPontuacao.Tick += new System.EventHandler(this.tmPontuacao_Tick);
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.Gold;
            this.lblPontuacao.Location = new System.Drawing.Point(824, 4);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(90, 25);
            this.lblPontuacao.TabIndex = 2;
            this.lblPontuacao.Text = "000000";
            // 
            // lblConsolacao
            // 
            this.lblConsolacao.AutoSize = true;
            this.lblConsolacao.BackColor = System.Drawing.Color.Transparent;
            this.lblConsolacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsolacao.ForeColor = System.Drawing.Color.Red;
            this.lblConsolacao.Location = new System.Drawing.Point(383, 280);
            this.lblConsolacao.Name = "lblConsolacao";
            this.lblConsolacao.Size = new System.Drawing.Size(155, 25);
            this.lblConsolacao.TabIndex = 21;
            this.lblConsolacao.Text = "000000 pontos";
            this.lblConsolacao.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 524);
            this.Controls.Add(this.lblConsolacao);
            this.Controls.Add(this.pnRaia);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lbLose);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnReiniciar);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
            this.pnRaia.ResumeLayout(false);
            this.pnRaia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstaculo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstaculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnRaia;
        private System.Windows.Forms.PictureBox pbPersonagem;
        private System.Windows.Forms.PictureBox pbObstaculo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbObstaculo2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lbLose;
        private System.Windows.Forms.Timer tmPontuacao;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblConsolacao;
    }
}