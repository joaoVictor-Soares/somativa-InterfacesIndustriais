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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 15);
            label1.Name = "label1";
            label1.Size = new Size(312, 37);
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
            panel2.Location = new Point(685, 99);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(216, 485);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(18, 445);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(178, 33);
            btnReset.TabIndex = 10;
            btnReset.Text = "RESET ALARME";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnManual
            // 
            btnManual.Location = new Point(18, 49);
            btnManual.Margin = new Padding(3, 4, 3, 4);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(178, 33);
            btnManual.TabIndex = 9;
            btnManual.Text = "AUTOMÁTICO";
            btnManual.UseVisualStyleBackColor = true;
            btnManual.Click += btnManual_Click;
            // 
            // btnAlarmes
            // 
            btnAlarmes.Location = new Point(18, 393);
            btnAlarmes.Margin = new Padding(3, 4, 3, 4);
            btnAlarmes.Name = "btnAlarmes";
            btnAlarmes.Size = new Size(178, 33);
            btnAlarmes.TabIndex = 8;
            btnAlarmes.Text = "ALARMES";
            btnAlarmes.UseVisualStyleBackColor = true;
            btnAlarmes.Click += btnAlarmes_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(18, 340);
            btnConectar.Margin = new Padding(3, 4, 3, 4);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(178, 33);
            btnConectar.TabIndex = 7;
            btnConectar.Text = "CONECTAR";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtTopico
            // 
            txtTopico.Location = new Point(15, 288);
            txtTopico.Margin = new Padding(3, 4, 3, 4);
            txtTopico.Name = "txtTopico";
            txtTopico.Size = new Size(186, 27);
            txtTopico.TabIndex = 6;
            txtTopico.Text = "industriais/sensores/4471";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 264);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 5;
            label5.Text = "TÓPICO";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(15, 208);
            txtPorta.Margin = new Padding(3, 4, 3, 4);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(186, 27);
            txtPorta.TabIndex = 4;
            txtPorta.Text = "1883";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 184);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "PORTA";
            // 
            // txtBroker
            // 
            txtBroker.Location = new Point(15, 129);
            txtBroker.Margin = new Padding(3, 4, 3, 4);
            txtBroker.Name = "txtBroker";
            txtBroker.Size = new Size(186, 27);
            txtBroker.TabIndex = 2;
            txtBroker.Text = "10.110.18.11";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 105);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 1;
            label3.Text = "BROKER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 16);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 0;
            label2.Text = "CONFIGURAÇÕES";
            // 
            // barTemperatura
            // 
            barTemperatura.Location = new Point(23, 164);
            barTemperatura.Margin = new Padding(3, 4, 3, 4);
            barTemperatura.Name = "barTemperatura";
            barTemperatura.Size = new Size(143, 31);
            barTemperatura.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(23, 177);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(143, 4);
            panel3.TabIndex = 3;
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTemperatura.Location = new Point(157, 120);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(61, 37);
            lblTemperatura.TabIndex = 5;
            lblTemperatura.Text = "0 °c";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNivel.Location = new Point(137, 415);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(62, 37);
            lblNivel.TabIndex = 25;
            lblNivel.Text = "0 %";
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlDarkDark;
            panel12.Location = new Point(21, 473);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(143, 4);
            panel12.TabIndex = 23;
            // 
            // barNivel
            // 
            barNivel.Location = new Point(21, 459);
            barNivel.Margin = new Padding(3, 4, 3, 4);
            barNivel.Name = "barNivel";
            barNivel.Size = new Size(143, 31);
            barNivel.TabIndex = 22;
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUmidade.Location = new Point(140, 501);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(62, 37);
            lblUmidade.TabIndex = 30;
            lblUmidade.Text = "0 %";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDarkDark;
            panel6.Location = new Point(23, 559);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(143, 4);
            panel6.TabIndex = 28;
            // 
            // barUmidade
            // 
            barUmidade.Location = new Point(23, 545);
            barUmidade.Margin = new Padding(3, 4, 3, 4);
            barUmidade.Name = "barUmidade";
            barUmidade.Size = new Size(143, 31);
            barUmidade.TabIndex = 27;
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPressao.Location = new Point(139, 320);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(79, 37);
            lblPressao.TabIndex = 30;
            lblPressao.Text = "0 bar";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ControlDarkDark;
            panel8.Location = new Point(23, 377);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(143, 4);
            panel8.TabIndex = 28;
            // 
            // barPressao
            // 
            barPressao.Location = new Point(23, 364);
            barPressao.Margin = new Padding(3, 4, 3, 4);
            barPressao.Name = "barPressao";
            barPressao.Size = new Size(143, 31);
            barPressao.TabIndex = 27;
            // 
            // lblVibracao
            // 
            lblVibracao.AutoSize = true;
            lblVibracao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVibracao.Location = new Point(131, 213);
            lblVibracao.Name = "lblVibracao";
            lblVibracao.Size = new Size(109, 37);
            lblVibracao.TabIndex = 30;
            lblVibracao.Text = "0 mm/s";
            // 
            // barVibracao
            // 
            barVibracao.Location = new Point(23, 257);
            barVibracao.Margin = new Padding(3, 4, 3, 4);
            barVibracao.Name = "barVibracao";
            barVibracao.Size = new Size(143, 31);
            barVibracao.TabIndex = 27;
            // 
            // lblAlarmeTemperatura
            // 
            lblAlarmeTemperatura.AutoSize = true;
            lblAlarmeTemperatura.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmeTemperatura.ForeColor = Color.Red;
            lblAlarmeTemperatura.Location = new Point(173, 158);
            lblAlarmeTemperatura.Name = "lblAlarmeTemperatura";
            lblAlarmeTemperatura.Size = new Size(54, 37);
            lblAlarmeTemperatura.TabIndex = 33;
            lblAlarmeTemperatura.Text = "⚠️";
            lblAlarmeTemperatura.Visible = false;
            // 
            // lblAlarmeVibracao
            // 
            lblAlarmeVibracao.AutoSize = true;
            lblAlarmeVibracao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmeVibracao.ForeColor = Color.Red;
            lblAlarmeVibracao.Location = new Point(170, 247);
            lblAlarmeVibracao.Name = "lblAlarmeVibracao";
            lblAlarmeVibracao.Size = new Size(54, 37);
            lblAlarmeVibracao.TabIndex = 34;
            lblAlarmeVibracao.Text = "⚠️";
            lblAlarmeVibracao.Visible = false;
            // 
            // lstAlarme
            // 
            lstAlarme.ForeColor = Color.Red;
            lstAlarme.FormattingEnabled = true;
            lstAlarme.Location = new Point(278, 440);
            lstAlarme.Margin = new Padding(3, 4, 3, 4);
            lstAlarme.Name = "lstAlarme";
            lstAlarme.Size = new Size(339, 144);
            lstAlarme.TabIndex = 32;
            lstAlarme.Visible = false;
            lstAlarme.SelectedIndexChanged += lstAlarme_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 133);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 35;
            label6.Text = "TEMPERATURA";
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(233, 133);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(120, 76);
            chart1.TabIndex = 36;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(914, 600);
            Controls.Add(chart1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
