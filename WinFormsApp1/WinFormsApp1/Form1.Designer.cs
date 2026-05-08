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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            button1 = new Button();
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 56);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = Color.DeepSkyBlue;
            button1.Location = new Point(654, 11);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 1;
            button1.Text = "SAIBA MAIS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panel2.Location = new Point(443, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(346, 209);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Location = new Point(186, 126);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(156, 25);
            btnRelatorio.TabIndex = 11;
            btnRelatorio.Text = "BAIXAR RELATÓRIO";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(186, 168);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(156, 25);
            btnReset.TabIndex = 10;
            btnReset.Text = "RESET ALARME";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnManual
            // 
            btnManual.Location = new Point(186, 38);
            btnManual.Name = "btnManual";
            btnManual.Size = new Size(156, 25);
            btnManual.TabIndex = 9;
            btnManual.Text = "AUTOMÁTICO";
            btnManual.UseVisualStyleBackColor = true;
            btnManual.Click += btnManual_Click;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(186, 82);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(156, 25);
            btnConectar.TabIndex = 7;
            btnConectar.Text = "CONECTAR";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtTopico
            // 
            txtTopico.Location = new Point(13, 160);
            txtTopico.Name = "txtTopico";
            txtTopico.Size = new Size(163, 23);
            txtTopico.TabIndex = 6;
            txtTopico.Text = "industriais/sensores/4471";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 142);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "TÓPICO";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(13, 100);
            txtPorta.Name = "txtPorta";
            txtPorta.Size = new Size(163, 23);
            txtPorta.TabIndex = 4;
            txtPorta.Text = "1883";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 82);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "PORTA";
            // 
            // txtBroker
            // 
            txtBroker.Location = new Point(13, 41);
            txtBroker.Name = "txtBroker";
            txtBroker.Size = new Size(163, 23);
            txtBroker.TabIndex = 2;
            txtBroker.Text = "10.110.18.11";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 23);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 1;
            label3.Text = "BROKER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 8);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 0;
            label2.Text = "CONFIGURAÇÕES";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTemperatura.Location = new Point(120, 2);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(25, 30);
            lblTemperatura.TabIndex = 5;
            lblTemperatura.Text = "0";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNivel.Location = new Point(120, 1);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(25, 30);
            lblNivel.TabIndex = 25;
            lblNivel.Text = "0";
            // 
            // lblUmidade
            // 
            lblUmidade.AutoSize = true;
            lblUmidade.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUmidade.Location = new Point(121, 1);
            lblUmidade.Name = "lblUmidade";
            lblUmidade.Size = new Size(25, 30);
            lblUmidade.TabIndex = 30;
            lblUmidade.Text = "0";
            // 
            // lblPressao
            // 
            lblPressao.AutoSize = true;
            lblPressao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPressao.Location = new Point(105, 1);
            lblPressao.Name = "lblPressao";
            lblPressao.Size = new Size(25, 30);
            lblPressao.TabIndex = 30;
            lblPressao.Text = "0";
            // 
            // lblVibracao
            // 
            lblVibracao.AutoSize = true;
            lblVibracao.BackColor = SystemColors.ControlDark;
            lblVibracao.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVibracao.Location = new Point(108, 1);
            lblVibracao.Name = "lblVibracao";
            lblVibracao.Size = new Size(25, 30);
            lblVibracao.TabIndex = 30;
            lblVibracao.Text = "0";
            lblVibracao.Click += lblVibracao_Click;
            // 
            // lblAlarmeTemperatura
            // 
            lblAlarmeTemperatura.AutoSize = true;
            lblAlarmeTemperatura.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlarmeTemperatura.ForeColor = Color.Red;
            lblAlarmeTemperatura.Location = new Point(40, 42);
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
            lblAlarmeVibracao.Location = new Point(40, 43);
            lblAlarmeVibracao.Name = "lblAlarmeVibracao";
            lblAlarmeVibracao.Size = new Size(42, 30);
            lblAlarmeVibracao.TabIndex = 34;
            lblAlarmeVibracao.Text = "⚠️";
            lblAlarmeVibracao.Visible = false;
            // 
            // lstAlarme
            // 
            lstAlarme.ForeColor = Color.Red;
            lstAlarme.FormattingEnabled = true;
            lstAlarme.Location = new Point(247, 323);
            lstAlarme.Name = "lstAlarme";
            lstAlarme.Size = new Size(542, 109);
            lstAlarme.TabIndex = 32;
            lstAlarme.SelectedIndexChanged += lstAlarme_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 6);
            label6.Name = "label6";
            label6.Size = new Size(98, 17);
            label6.TabIndex = 35;
            label6.Text = "TEMPERATURA";
            // 
            // chartTemperatura
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
            chartTemperatura.ChartAreas.Add(chartArea1);
            chartTemperatura.Location = new Point(9, 26);
            chartTemperatura.Margin = new Padding(3, 2, 3, 2);
            chartTemperatura.Name = "chartTemperatura";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTemperatura.Series.Add(series1);
            chartTemperatura.Size = new Size(105, 61);
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
            panel4.Location = new Point(18, 82);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(172, 90);
            panel4.TabIndex = 37;
            // 
            // verticalBarTemperatura
            // 
            verticalBarTemperatura.Location = new Point(124, 26);
            verticalBarTemperatura.Margin = new Padding(3, 2, 3, 2);
            verticalBarTemperatura.Name = "verticalBarTemperatura";
            verticalBarTemperatura.Size = new Size(18, 61);
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
            panel3.Location = new Point(18, 201);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 90);
            panel3.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 8);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 39;
            label7.Text = "VIBRAÇÃO";
            // 
            // chartVibracao
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.LineColor = Color.Transparent;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.LineColor = Color.Transparent;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.Name = "ChartArea1";
            chartVibracao.ChartAreas.Add(chartArea2);
            chartVibracao.Location = new Point(9, 26);
            chartVibracao.Margin = new Padding(3, 2, 3, 2);
            chartVibracao.Name = "chartVibracao";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartVibracao.Series.Add(series2);
            chartVibracao.Size = new Size(105, 61);
            chartVibracao.TabIndex = 39;
            chartVibracao.Text = "chartVibracao";
            // 
            // verticalBarVibracao
            // 
            verticalBarVibracao.Location = new Point(124, 26);
            verticalBarVibracao.Margin = new Padding(3, 2, 3, 2);
            verticalBarVibracao.Name = "verticalBarVibracao";
            verticalBarVibracao.Size = new Size(18, 61);
            verticalBarVibracao.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(chartPressao);
            panel5.Controls.Add(verticalBarPressao);
            panel5.Controls.Add(lblPressao);
            panel5.Location = new Point(18, 323);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(172, 90);
            panel5.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 8);
            label8.Name = "label8";
            label8.Size = new Size(64, 17);
            label8.TabIndex = 39;
            label8.Text = "PRESSÃO";
            // 
            // chartPressao
            // 
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.LineColor = Color.Transparent;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea3.AxisY.LabelStyle.Enabled = false;
            chartArea3.AxisY.LineColor = Color.Transparent;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.Name = "ChartArea1";
            chartPressao.ChartAreas.Add(chartArea3);
            chartPressao.Location = new Point(9, 26);
            chartPressao.Margin = new Padding(3, 2, 3, 2);
            chartPressao.Name = "chartPressao";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartPressao.Series.Add(series3);
            chartPressao.Size = new Size(105, 61);
            chartPressao.TabIndex = 39;
            chartPressao.Text = "chartPressao";
            // 
            // verticalBarPressao
            // 
            verticalBarPressao.Location = new Point(124, 26);
            verticalBarPressao.Margin = new Padding(3, 2, 3, 2);
            verticalBarPressao.Name = "verticalBarPressao";
            verticalBarPressao.Size = new Size(18, 61);
            verticalBarPressao.TabIndex = 39;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.ControlDarkDark;
            panel12.Location = new Point(247, 64);
            panel12.Name = "panel12";
            panel12.Size = new Size(125, 3);
            panel12.TabIndex = 23;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlDark;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(lblUmidade);
            panel6.Controls.Add(chartUmidade);
            panel6.Controls.Add(verticalBarUmidade);
            panel6.Location = new Point(247, 82);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(172, 90);
            panel6.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 7);
            label9.Name = "label9";
            label9.Size = new Size(68, 17);
            label9.TabIndex = 39;
            label9.Text = "UMIDADE";
            // 
            // chartUmidade
            // 
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.LineColor = Color.Transparent;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea4.AxisY.LabelStyle.Enabled = false;
            chartArea4.AxisY.LineColor = Color.Transparent;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.Name = "ChartArea1";
            chartUmidade.ChartAreas.Add(chartArea4);
            chartUmidade.Location = new Point(9, 26);
            chartUmidade.Margin = new Padding(3, 2, 3, 2);
            chartUmidade.Name = "chartUmidade";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartUmidade.Series.Add(series4);
            chartUmidade.Size = new Size(105, 61);
            chartUmidade.TabIndex = 39;
            chartUmidade.Text = "chartUmidade";
            // 
            // verticalBarUmidade
            // 
            verticalBarUmidade.Location = new Point(124, 26);
            verticalBarUmidade.Margin = new Padding(3, 2, 3, 2);
            verticalBarUmidade.Name = "verticalBarUmidade";
            verticalBarUmidade.Size = new Size(18, 61);
            verticalBarUmidade.TabIndex = 39;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDark;
            panel7.Controls.Add(label10);
            panel7.Controls.Add(chartNivel);
            panel7.Controls.Add(lblNivel);
            panel7.Controls.Add(verticalBarNivel);
            panel7.Location = new Point(247, 201);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(172, 90);
            panel7.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 8);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 39;
            label10.Text = "NÍVEL";
            // 
            // chartNivel
            // 
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisX.LineColor = Color.Transparent;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX2.TitleForeColor = Color.BlanchedAlmond;
            chartArea5.AxisY.LabelStyle.Enabled = false;
            chartArea5.AxisY.LineColor = Color.Transparent;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorTickMark.Enabled = false;
            chartArea5.Name = "ChartArea1";
            chartNivel.ChartAreas.Add(chartArea5);
            chartNivel.Location = new Point(9, 26);
            chartNivel.Margin = new Padding(3, 2, 3, 2);
            chartNivel.Name = "chartNivel";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chartNivel.Series.Add(series5);
            chartNivel.Size = new Size(105, 61);
            chartNivel.TabIndex = 39;
            chartNivel.Text = "chartNivel";
            // 
            // verticalBarNivel
            // 
            verticalBarNivel.Location = new Point(124, 26);
            verticalBarNivel.Margin = new Padding(3, 2, 3, 2);
            verticalBarNivel.Name = "verticalBarNivel";
            verticalBarNivel.Size = new Size(18, 61);
            verticalBarNivel.TabIndex = 39;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel12);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lstAlarme);
            Controls.Add(panel4);
            Controls.Add(panel3);
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
        private Button button1;
    }
}
