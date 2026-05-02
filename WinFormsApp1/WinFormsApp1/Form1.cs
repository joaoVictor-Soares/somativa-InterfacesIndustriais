using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using System.Text;
using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private IMqttClient clienteMqtt;
        private bool listaAlarme = false;
        private bool manual = false;
        private bool conectar = false;
        private bool relatorio = false;
        private ArrayList arrayDados = new ArrayList();
        private int pointGrafico = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnConectar_Click(object sender, EventArgs e)
        {
            conectar = !conectar;
            if (conectar)
            {
                btnConectar.Text = "DESCONECTAR";
                var fabrica = new MqttFactory();
                clienteMqtt = fabrica.CreateMqttClient();

                clienteMqtt.ApplicationMessageReceivedAsync += eMessage =>
                {
                    string mensagem = Encoding.UTF8.GetString(eMessage.ApplicationMessage.Payload);

                    DadosMqtt dados = JsonConvert.DeserializeObject<DadosMqtt>(mensagem);

                    Invoke((System.Windows.Forms.MethodInvoker)delegate
                    {
                        lblTemperatura.Text = dados.temperatura.ToString();
                        verticalBarTemperatura.Value = dados.temperatura;

                        lblUmidade.Text = dados.umidade.ToString();
                        verticalBarUmidade.Value = dados.umidade;

                        lblPressao.Text = dados.pressao.ToString();
                        verticalBarPressao.Value = (int)dados.pressao;

                        lblVibracao.Text = dados.vibracao.ToString();
                        verticalBarVibracao.Value = (int)dados.vibracao;

                        lblNivel.Text = dados.nivel.ToString();
                        verticalBarNivel.Value = dados.nivel;

                        DateTime data = DateTime.Now;
                        string relatorioDados = data + "| Temperatura: " + dados.temperatura + " | Umidade: " + dados.umidade + " | Pressão: " + dados.pressao + " | Nível: " + dados.nivel + " | Vibração: " + dados.vibracao;

                        arrayDados.Add(relatorioDados);


                        if (dados.temperatura >= 75)
                        {
                            lblAlarmeTemperatura.Visible = true;
                            string alarme = data + "| temperatura: " + dados.temperatura;
                            lstAlarme.Items.Add(alarme);
                        }

                        if (dados.vibracao >= 18)
                        {
                            lblAlarmeVibracao.Visible = true;
                            string alarme = data + "| vibracao: " + dados.vibracao;
                            lstAlarme.Items.Add(alarme);
                        }

                        plotGraficos(dados.temperatura, dados.umidade, dados.pressao, dados.vibracao, dados.nivel);
                        pointGrafico++;
                    });

                    return System.Threading.Tasks.Task.CompletedTask;
                };

                var opcoes = new MqttClientOptionsBuilder()
                    .WithTcpServer(txtBroker.Text, int.Parse(txtPorta.Text))
                    .Build();

                await clienteMqtt.ConnectAsync(opcoes);

                await clienteMqtt.SubscribeAsync(txtTopico.Text);
            }
            else
            {
                btnConectar.Text = "CONECTAR";
                clienteMqtt.DisconnectAsync();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblAlarmeVibracao.Visible = false;
            lblAlarmeTemperatura.Visible = false;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            manual = !manual;

            if (manual)
            {
                btnManual.Text = "MANUAL";
                txtBroker.Enabled = false;
                txtPorta.Enabled = false;
                txtTopico.Enabled = false;
                btnRelatorio.Enabled = false;
                btnReset.Enabled = false;
                btnConectar.Enabled = false;
            }
            else
            {
                btnManual.Text = "AUTOMÁTICO";
                txtBroker.Enabled = true;
                txtPorta.Enabled = true;
                txtTopico.Enabled = true;
                btnRelatorio.Enabled = true;
                btnReset.Enabled = true;
                btnConectar.Enabled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstAlarme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void plotGraficos(int temperatura, int umidade, float pressao, float vibracao, int nivel)
        {
            chartTemperatura.Series["Series1"].Points.AddXY(pointGrafico, temperatura);
            chartUmidade.Series["Series1"].Points.AddXY(pointGrafico, umidade);
            chartPressao.Series["Series1"].Points.AddXY(pointGrafico, pressao);
            chartVibracao.Series["Series1"].Points.AddXY(pointGrafico, vibracao);
            chartNivel.Series["Series1"].Points.AddXY(pointGrafico, nivel);
        }

        private void lblVibracao_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;

            string caminho = $"{data:yyyy-MM-dd}_relatorio.txt";
            string conteudo = "";

            if (!File.Exists(caminho))
            {
                    File.WriteAllText(caminho, conteudo);
            }
            foreach (string dados in arrayDados)
            {
                File.AppendAllText(caminho, dados + Environment.NewLine);
            }
            btnRelatorio.Text = "RELATÓRIO GERADO";
            btnRelatorio.Enabled = false;

        }
    }
    public class VerticalProgressBar : ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04; // Adiciona o estilo PBS_VERTICAL
                return cp;
            }
        }
    }
}

public class DadosMqtt 
{ 
    public int temperatura { get; set; }
    public int umidade { get; set; }
    public float pressao { get; set; }
    public int nivel { get; set; }
    public float vibracao { get; set; }
}



