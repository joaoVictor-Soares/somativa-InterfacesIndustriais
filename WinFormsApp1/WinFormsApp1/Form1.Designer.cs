namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnReset = new Button();
            btnManual = new Button();
            btnAlarmes = new Button();
            btnConectar = new Button();
            txtTopico = new TextBox();
            label5 = new Label();
            txtPorta = new TextBox();
            label4 = new Label();
            txtBroker = new TextBox();
            label3 = new Label();
            label2 = new Label();
            barTemperatura = new ProgressBar();
            panel3 = new Panel();
            lblTemperatura = new Label();
            lblNivel = new Label();
            panel12 = new Panel();
            barNivel = new ProgressBar();
            lblUmidade = new Label();
            panel6 = new Panel();
            barUmidade = new ProgressBar();
            lblPressao = new Label();
            panel8 = new Panel();
            barPressao = new ProgressBar();
            lblVibracao = new Label();
            barVibracao = new ProgressBar();
            lblAlarmeTemperatura = new Label();
            lblAlarmeVibracao = new Label();
            lstAlarme = new ListBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 56);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 11);
            label1.Name = "label1";
            label1.Size = new Size(247, 30);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA SUPERVISÓRIO";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnManual);
            panel2.Controls.Add(btnAlarmes);
            panel2.Controls.Add(btnConectar);
            panel2.Controls.Add(txtTopico);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPorta);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBroker);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(599, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 364);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(16, 334);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(156, 25);
            btnReset.TabIndex = 10;
            btnReset.Text = "RESET ALARME";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnManual
            // 
            btnManual.Location = new Point(16, 37);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(156, 25);
            btnManual.TabIndex = 9;
            btnManual.Text = "AUTOMÁTICO";
            btnManual.UseVisualStyleBackColor = true;
            btnManual.Click += btnManual_Click;
            // 
            // btnAlarmes
            // 
            btnAlarmes.Location = new Point(16, 295);
            btnAlarmes.Name = "btnAlarmes";
            btnAlarmes.Size = new Size(156, 25);
            btnAlarmes.TabIndex = 8;
            btnAlarmes.Text = "ALARMES";
            btnAlarmes.UseVisualStyleBackColor = true;
            btnAlarmes.Click += btnAlarmes_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(16, 255);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(156, 25);
            btnConectar.TabIndex = 7;
            btnConectar.Text = "CONECTAR";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtTopico
            // 
            txtTopico.Location = new Point(13, 216);
            txtTopico.Name = "txtTopico";
            txtTopico.Size = new Size(163, 23);
            txtTopico.TabIndex = 6;
            txtTopico.Text = "industriais/sensores/4471";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 198);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "TÓPICO";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(13, 156);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(163, 23);
            txtPorta.TabIndex = 4;
            txtPorta.Text = "1883";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 138);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "PORTA";
            // 
            // txtBroker
            // 
            txtBroker.Location = new Point(13, 97);
            txtBroker.Name = "txtBroker";
            txtBroker.Size = new Size(163, 23);
            txtBroker.TabIndex = 2;
            txtBroker.Text = "10.110.18.11";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 79);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 1;
            label3.Text = "BROKER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 12);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 0;
            label2.Text = "CONFIGURAÇÕES";
            // 
            // barTemperatura
            // 
            barTemperatura.Location = new Point(48, 143);
            barTemperatura.Name = "barTemperatura";
            barTemperatura.Size = new Size(125, 23);
            barTemperatura.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(48, 153);
            panel3.Name = "panel3";
            panel3.Size = new Size(125, 3);
            panel3.TabIndex = 3;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTemperatura.Location = new Point(165, 110);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(48, 30);
            lblTemperatura.TabIndex = 5;
            lblTemperatura.Text = "0 °c";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNivel.Location = new Point(150, 352);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(49, 30);
            lblNivel.TabIndex = 25;
            lblNivel.Text = "0 %";
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlDarkDark;
            panel12.Location = new Point(48, 395);
            panel12.Name = "panel12";
            panel12.Size = new Size(125, 3);
            panel12.TabIndex = 23;
            // 
            // barNivel
            // 
            barNivel.Location = new Point(48, 385);
            barNivel.Name = "barNivel";
            barNivel.Size = new Size(125, 23);
            barNivel.TabIndex = 22;
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUmidade.Location = new Point(508, 352);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(49, 30);
            lblUmidade.TabIndex = 30;
            lblUmidade.Text = "0 %";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Location = new Point(406, 395);
            panel6.Name = "panel6";
            panel6.Size = new Size(125, 3);
            panel6.TabIndex = 28;
            // 
            // barUmidade
            // 
            barUmidade.Location = new Point(406, 385);
            barUmidade.Name = "barUmidade";
            barUmidade.Size = new Size(125, 23);
            barUmidade.TabIndex = 27;
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPressao.Location = new Point(359, 222);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(63, 30);
            lblPressao.TabIndex = 30;
            lblPressao.Text = "0 bar";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlDarkDark;
            panel8.Location = new Point(257, 265);
            panel8.Name = "panel8";
            panel8.Size = new Size(125, 3);
            panel8.TabIndex = 28;
            // 
            // barPressao
            // 
            barPressao.Location = new Point(257, 255);
            barPressao.Name = "barPressao";
            barPressao.Size = new Size(125, 23);
            barPressao.TabIndex = 27;
            // 
            // lblVibracao
            // 
            lblVibracao.AutoSize = true;
            lblVibracao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVibracao.Location = new Point(491, 113);
            lblVibracao.Name = "lblVibracao";
            lblVibracao.Size = new Size(87, 30);
            lblVibracao.TabIndex = 30;
            lblVibracao.Text = "0 mm/s";
            // 
            // barVibracao
            // 
            barVibracao.Location = new Point(396, 146);
            barVibracao.Name = "barVibracao";
            barVibracao.Size = new Size(125, 23);
            barVibracao.TabIndex = 27;
            // 
            // lblAlarmeTemperatura
            // 
            lblAlarmeTemperatura.AutoSize = true;
            lblAlarmeTemperatura.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmeTemperatura.ForeColor = Color.Red;
            lblAlarmeTemperatura.Location = new Point(179, 139);
            lblAlarmeTemperatura.Name = "lblAlarmeTemperatura";
            lblAlarmeTemperatura.Size = new Size(42, 30);
            lblAlarmeTemperatura.TabIndex = 33;
            lblAlarmeTemperatura.Text = "⚠️";
            lblAlarmeTemperatura.Visible = false;
            // 
            // lblAlarmeVibracao
            // 
            lblAlarmeVibracao.AutoSize = true;
            lblAlarmeVibracao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmeVibracao.ForeColor = Color.Red;
            lblAlarmeVibracao.Location = new Point(525, 139);
            lblAlarmeVibracao.Name = "lblAlarmeVibracao";
            lblAlarmeVibracao.Size = new Size(42, 30);
            lblAlarmeVibracao.TabIndex = 34;
            lblAlarmeVibracao.Text = "⚠️";
            lblAlarmeVibracao.Visible = false;
            // 
            // lstAlarme
            // 
            lstAlarme.FormattingEnabled = true;
            lstAlarme.Location = new Point(18, 74);
            lstAlarme.Name = "lstAlarme";
            lstAlarme.Size = new Size(575, 349);
            lstAlarme.TabIndex = 32;
            lstAlarme.Visible = false;
            lstAlarme.SelectedIndexChanged += lstAlarme_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 120);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 35;
            label6.Text = "TEMPERATURA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(lblAlarmeVibracao);
            Controls.Add(lblAlarmeTemperatura);
            Controls.Add(barVibracao);
            Controls.Add(barNivel);
            Controls.Add(barPressao);
            Controls.Add(barUmidade);
            Controls.Add(barTemperatura);
            Controls.Add(lblVibracao);
            Controls.Add(lblPressao);
            Controls.Add(lblUmidade);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(lblNivel);
            Controls.Add(panel12);
            Controls.Add(lblTemperatura);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lstAlarme);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txtTopico;
        private Label label5;
        private TextBox txtPorta;
        private Label label4;
        private TextBox txtBroker;
        private Label label3;
        private Button btnAlarmes;
        private Button btnConectar;
        private Button btnManual;
        private ProgressBar barTemperatura;
        private Panel panel3;
        private Label lblTemperatura;
        private Label lblNivel;
        private Panel panel12;
        private ProgressBar barNivel;
        private Label lblUmidade;
        private Panel panel6;
        private ProgressBar barUmidade;
        private Label lblPressao;
        private Panel panel8;
        private ProgressBar barPressao;
        private Label lblVibracao;
        private ProgressBar barVibracao;
        private Button btnReset;
        private Label lblAlarmeTemperatura;
        private Label lblAlarmeVibracao;
        private ListBox lstAlarme;
        private Label label6;
    }
}
