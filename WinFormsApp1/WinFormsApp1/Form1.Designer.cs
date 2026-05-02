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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnRelatorio = new Button();
            btnReset = new Button();
            btnManual = new Button();
            btnConectar = new Button();
            txtTopico = new TextBox();
            label5 = new Label();
            txtPorta = new TextBox();
            label4 = new Label();
            txtBroker = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblTemperatura = new Label();
            lblNivel = new Label();
            lblUmidade = new Label();
            lblPressao = new Label();
            lblVibracao = new Label();
            lblAlarmeTemperatura = new Label();
            lblAlarmeVibracao = new Label();
            lstAlarme = new ListBox();
            label6 = new Label();
            chartTemperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel4 = new Panel();
            verticalBarTemperatura = new VerticalProgressBar();
            panel3 = new Panel();
            label7 = new Label();
            chartVibracao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            verticalBarVibracao = new VerticalProgressBar();
            panel5 = new Panel();
            label8 = new Label();
            chartPressao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            verticalBarPressao = new VerticalProgressBar();
            panel12 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            chartUmidade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            verticalBarUmidade = new VerticalProgressBar();
            panel7 = new Panel();
            label10 = new Label();
            chartNivel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            verticalBarNivel = new VerticalProgressBar();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTemperatura).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVibracao).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPressao).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartUmidade).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartNivel).BeginInit();
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
            panel2.Controls.Add(btnRelatorio);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnManual);
            panel2.Controls.Add(btnConectar);
            panel2.Controls.Add(txtTopico);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPorta);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBroker);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(506, 110);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 278);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(212, 168);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(178, 33);
            btnRelatorio.TabIndex = 11;
            btnRelatorio.Text = "BAIXAR RELATÓRIO";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(212, 224);
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
            btnManual.Location = new Point(212, 50);
            btnManual.Margin = new Padding(3, 4, 3, 4);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(178, 33);
            btnManual.TabIndex = 9;
            btnManual.Text = "AUTOMÁTICO";
            btnManual.UseVisualStyleBackColor = true;
            btnManual.Click += btnManual_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(212, 110);
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
            txtTopico.Location = new Point(15, 214);
            txtTopico.Margin = new Padding(3, 4, 3, 4);
            txtTopico.Name = "txtTopico";
            txtTopico.Size = new Size(186, 27);
            txtTopico.TabIndex = 6;
            txtTopico.Text = "industriais/sensores/4471";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 190);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 5;
            label5.Text = "TÓPICO";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(15, 134);
            txtPorta.Margin = new Padding(3, 4, 3, 4);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(186, 27);
            txtPorta.TabIndex = 4;
            txtPorta.Text = "1883";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 110);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "PORTA";
            // 
            // txtBroker
            // 
            txtBroker.Location = new Point(15, 55);
            txtBroker.Margin = new Padding(3, 4, 3, 4);
            txtBroker.Name = "txtBroker";
            txtBroker.Size = new Size(186, 27);
            txtBroker.TabIndex = 2;
            txtBroker.Text = "10.110.18.11";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 31);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 1;
            label3.Text = "BROKER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 11);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 0;
            label2.Text = "CONFIGURAÇÕES";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTemperatura.Location = new Point(137, 2);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(32, 37);
            lblTemperatura.TabIndex = 5;
            lblTemperatura.Text = "0";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNivel.Location = new Point(137, 1);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(32, 37);
            lblNivel.TabIndex = 25;
            lblNivel.Text = "0";
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUmidade.Location = new Point(138, 1);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(32, 37);
            lblUmidade.TabIndex = 30;
            lblUmidade.Text = "0";
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPressao.Location = new Point(120, 1);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(32, 37);
            lblPressao.TabIndex = 30;
            lblPressao.Text = "0";
            // 
            // lblVibracao
            // 
            lblVibracao.AutoSize = true;
            lblVibracao.BackColor = SystemColors.ControlDark;
            lblVibracao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVibracao.Location = new Point(124, 1);
            lblVibracao.Name = "lblVibracao";
            lblVibracao.Size = new Size(32, 37);
            lblVibracao.TabIndex = 30;
            lblVibracao.Text = "0";
            lblVibracao.Click += lblVibracao_Click;
            // 
            // lblAlarmeTemperatura
            // 
            lblAlarmeTemperatura.AutoSize = true;
            lblAlarmeTemperatura.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmeTemperatura.ForeColor = Color.Red;
            lblAlarmeTemperatura.Location = new Point(46, 56);
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
            lblAlarmeVibracao.Location = new Point(46, 57);
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
            lstAlarme.Location = new Point(282, 431);
            lstAlarme.Margin = new Padding(3, 4, 3, 4);
            lstAlarme.Name = "lstAlarme";
            lstAlarme.Size = new Size(619, 144);
            lstAlarme.TabIndex = 32;
            lstAlarme.SelectedIndexChanged += lstAlarme_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 8);
            label6.Name = "label6";
            label6.Size = new Size(124, 23);
            label6.TabIndex = 35;
            label6.Text = "TEMPERATURA";
            // 
            // chartTemperatura
            // 
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisX.LineColor = Color.Transparent;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea6.AxisY.LabelStyle.Enabled = false;
            chartArea6.AxisY.LineColor = Color.Transparent;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorTickMark.Enabled = false;
            chartArea6.Name = "ChartArea1";
            chartTemperatura.ChartAreas.Add(chartArea6);
            chartTemperatura.Location = new Point(10, 35);
            chartTemperatura.Name = "chartTemperatura";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            chartTemperatura.Series.Add(series6);
            chartTemperatura.Size = new Size(120, 81);
            chartTemperatura.TabIndex = 36;
            chartTemperatura.Text = "chartTemperatura";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDark;
            panel4.Controls.Add(verticalBarTemperatura);
            panel4.Controls.Add(lblAlarmeTemperatura);
            panel4.Controls.Add(chartTemperatura);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lblTemperatura);
            panel4.Location = new Point(21, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 120);
            panel4.TabIndex = 37;
            // 
            // verticalBarTemperatura
            // 
            verticalBarTemperatura.Location = new Point(142, 35);
            verticalBarTemperatura.Name = "verticalBarTemperatura";
            verticalBarTemperatura.Size = new Size(20, 81);
            verticalBarTemperatura.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblAlarmeVibracao);
            panel3.Controls.Add(chartVibracao);
            panel3.Controls.Add(verticalBarVibracao);
            panel3.Controls.Add(lblVibracao);
            panel3.Location = new Point(21, 268);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 120);
            panel3.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 11);
            label7.Name = "label7";
            label7.Size = new Size(92, 23);
            label7.TabIndex = 39;
            label7.Text = "VIBRAÇÃO";
            // 
            // chartVibracao
            // 
            chartArea7.AxisX.LabelStyle.Enabled = false;
            chartArea7.AxisX.LineColor = Color.Transparent;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorTickMark.Enabled = false;
            chartArea7.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea7.AxisY.LabelStyle.Enabled = false;
            chartArea7.AxisY.LineColor = Color.Transparent;
            chartArea7.AxisY.MajorGrid.Enabled = false;
            chartArea7.AxisY.MajorTickMark.Enabled = false;
            chartArea7.Name = "ChartArea1";
            chartVibracao.ChartAreas.Add(chartArea7);
            chartVibracao.Location = new Point(10, 34);
            chartVibracao.Name = "chartVibracao";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            chartVibracao.Series.Add(series7);
            chartVibracao.Size = new Size(120, 81);
            chartVibracao.TabIndex = 39;
            chartVibracao.Text = "chartVibracao";
            // 
            // verticalBarVibracao
            // 
            verticalBarVibracao.Location = new Point(142, 35);
            verticalBarVibracao.Name = "verticalBarVibracao";
            verticalBarVibracao.Size = new Size(20, 81);
            verticalBarVibracao.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(chartPressao);
            panel5.Controls.Add(verticalBarPressao);
            panel5.Controls.Add(lblPressao);
            panel5.Location = new Point(21, 431);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 120);
            panel5.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 11);
            label8.Name = "label8";
            label8.Size = new Size(81, 23);
            label8.TabIndex = 39;
            label8.Text = "PRESSÃO";
            // 
            // chartPressao
            // 
            chartArea8.AxisX.LabelStyle.Enabled = false;
            chartArea8.AxisX.LineColor = Color.Transparent;
            chartArea8.AxisX.MajorGrid.Enabled = false;
            chartArea8.AxisX.MajorTickMark.Enabled = false;
            chartArea8.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea8.AxisY.LabelStyle.Enabled = false;
            chartArea8.AxisY.LineColor = Color.Transparent;
            chartArea8.AxisY.MajorGrid.Enabled = false;
            chartArea8.AxisY.MajorTickMark.Enabled = false;
            chartArea8.Name = "ChartArea1";
            chartPressao.ChartAreas.Add(chartArea8);
            chartPressao.Location = new Point(10, 34);
            chartPressao.Name = "chartPressao";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            chartPressao.Series.Add(series8);
            chartPressao.Size = new Size(120, 81);
            chartPressao.TabIndex = 39;
            chartPressao.Text = "chartPressao";
            // 
            // verticalBarPressao
            // 
            verticalBarPressao.Location = new Point(142, 35);
            verticalBarPressao.Name = "verticalBarPressao";
            verticalBarPressao.Size = new Size(20, 81);
            verticalBarPressao.TabIndex = 39;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlDarkDark;
            panel12.Location = new Point(282, 86);
            panel12.Margin = new Padding(3, 4, 3, 4);
            panel12.Name = "panel12";
            panel12.Size = new Size(143, 4);
            panel12.TabIndex = 23;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(lblUmidade);
            panel6.Controls.Add(chartUmidade);
            panel6.Controls.Add(verticalBarUmidade);
            panel6.Location = new Point(282, 110);
            panel6.Name = "panel6";
            panel6.Size = new Size(197, 120);
            panel6.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 9);
            label9.Name = "label9";
            label9.Size = new Size(85, 23);
            label9.TabIndex = 39;
            label9.Text = "UMIDADE";
            // 
            // chartUmidade
            // 
            chartArea9.AxisX.LabelStyle.Enabled = false;
            chartArea9.AxisX.LineColor = Color.Transparent;
            chartArea9.AxisX.MajorGrid.Enabled = false;
            chartArea9.AxisX.MajorTickMark.Enabled = false;
            chartArea9.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea9.AxisY.LabelStyle.Enabled = false;
            chartArea9.AxisY.LineColor = Color.Transparent;
            chartArea9.AxisY.MajorGrid.Enabled = false;
            chartArea9.AxisY.MajorTickMark.Enabled = false;
            chartArea9.Name = "ChartArea1";
            chartUmidade.ChartAreas.Add(chartArea9);
            chartUmidade.Location = new Point(10, 34);
            chartUmidade.Name = "chartUmidade";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            chartUmidade.Series.Add(series9);
            chartUmidade.Size = new Size(120, 81);
            chartUmidade.TabIndex = 39;
            chartUmidade.Text = "chartUmidade";
            // 
            // verticalBarUmidade
            // 
            verticalBarUmidade.Location = new Point(142, 35);
            verticalBarUmidade.Name = "verticalBarUmidade";
            verticalBarUmidade.Size = new Size(20, 81);
            verticalBarUmidade.TabIndex = 39;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDark;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(chartNivel);
            panel7.Controls.Add(lblNivel);
            panel7.Controls.Add(verticalBarNivel);
            panel7.Location = new Point(282, 268);
            panel7.Name = "panel7";
            panel7.Size = new Size(197, 120);
            panel7.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 10);
            label10.Name = "label10";
            label10.Size = new Size(56, 23);
            label10.TabIndex = 39;
            label10.Text = "NÍVEL";
            // 
            // chartNivel
            // 
            chartArea10.AxisX.LabelStyle.Enabled = false;
            chartArea10.AxisX.LineColor = Color.Transparent;
            chartArea10.AxisX.MajorGrid.Enabled = false;
            chartArea10.AxisX.MajorTickMark.Enabled = false;
            chartArea10.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea10.AxisY.LabelStyle.Enabled = false;
            chartArea10.AxisY.LineColor = Color.Transparent;
            chartArea10.AxisY.MajorGrid.Enabled = false;
            chartArea10.AxisY.MajorTickMark.Enabled = false;
            chartArea10.Name = "ChartArea1";
            chartNivel.ChartAreas.Add(chartArea10);
            chartNivel.Location = new Point(10, 34);
            chartNivel.Name = "chartNivel";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            chartNivel.Series.Add(series10);
            chartNivel.Size = new Size(120, 81);
            chartNivel.TabIndex = 39;
            chartNivel.Text = "chartNivel";
            // 
            // verticalBarNivel
            // 
            verticalBarNivel.Location = new Point(142, 35);
            verticalBarNivel.Name = "verticalBarNivel";
            verticalBarNivel.Size = new Size(20, 81);
            verticalBarNivel.TabIndex = 39;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(914, 600);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel12);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lstAlarme);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTemperatura).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVibracao).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPressao).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartUmidade).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartNivel).EndInit();
            ResumeLayout(false);
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
        private Button btnConectar;
        private Button btnManual;
        private Label lblTemperatura;
        private Label lblNivel;
        private Label lblUmidade;
        private Label lblPressao;
        private Label lblVibracao;
        private Button btnReset;
        private Label lblAlarmeTemperatura;
        private Label lblAlarmeVibracao;
        private ListBox lstAlarme;
        private Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperatura;
        private Panel panel4;
        private ProgressBar barTemperatura;
        private VerticalProgressBar verticalBarTemperatura;
        private Panel panel3;
        private VerticalProgressBar verticalBarVibracao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVibracao;
        private Panel panel5;
        private Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressao;
        private VerticalProgressBar verticalBarPressao;
        private Label label7;
        private Panel panel12;
        private Panel panel6;
        private Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUmidade;
        private VerticalProgressBar verticalBarUmidade;
        private Panel panel7;
        private Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNivel;
        private VerticalProgressBar verticalBarNivel;
        private Label label11;
        private Button btnRelatorio;
    }
}
