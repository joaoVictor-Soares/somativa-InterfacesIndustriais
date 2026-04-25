using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using System.Reflection;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private IMqttClient clienteMqtt;
        private bool listaAlarme = false;
        private bool manual = false;
        private bool conectar = false;
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
                        barTemperatura.Value = dados.temperatura;

                        lblUmidade.Text = dados.umidade.ToString();
                        barUmidade.Value = dados.umidade;

                        lblPressao.Text = dados.pressao.ToString();
                        barPressao.Value = (int)dados.pressao;

                        lblVibracao.Text = dados.vibracao.ToString();
                        barVibracao.Value = (int)dados.vibracao;

                        lblNivel.Text = dados.nivel.ToString();
                        barNivel.Value = dados.nivel;

                        if (dados.temperatura >= 75)
                        {
                            lblAlarmeTemperatura.Visible = true;
                            DateTime data = DateTime.Now;
                            string alarme = data + "| temperatura: " + dados.temperatura;
                            lstAlarme.Items.Add(alarme);
                        }

                        if (dados.vibracao >= 18)
                        {
                            lblAlarmeVibracao.Visible = true;
                            DateTime data = DateTime.Now;
                            string alarme = data + "| vibracao: " + dados.vibracao;
                            lstAlarme.Items.Add(alarme);
                        }
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

        private void btnAlarmes_Click(object sender, EventArgs e)
        {
            listaAlarme = !listaAlarme;

            if (listaAlarme)
            {
                lstAlarme.Visible = true;
                btnAlarmes.Text = "ESCONDER LISTA";
            }
            else
            {
                lstAlarme.Visible = false;
                btnAlarmes.Text = "ALARMES";
            }
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
                btnAlarmes.Enabled = false;
                btnReset.Enabled = false;
                btnConectar.Enabled = false;
            }
            else
            {
                btnManual.Text = "AUTOMÁTICO";
                txtBroker.Enabled = true;
                txtPorta.Enabled = true;
                txtTopico.Enabled = true;
                btnAlarmes.Enabled = true;
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

