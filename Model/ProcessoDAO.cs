using AppWebExemplo.Configs;


namespace Latatumba.Model
{
    public class ProcessoDAO
    {
        private readonly Conexao _conexao;

        public ProcessoDAO(Conexao conexao)
        {
            _conexao = conexao;
        }

        public List<Processo> Listar()
        {
            try
            {
                var lista = new List<Processo>();

                using var con = _conexao.GetConnection();
                con.Open();

                using var comando = con.CreateCommand();

                comando.CommandText = @"
                    SELECT 
                        id_pro,
                        numero_pro,
                        data_pro,
                        interessado_pro,
                        assunto_pro,
                        descricao_pro,
                        situacao_pro
                    FROM processos;
                ";

                using var leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    var processo = new Processo();

                    processo.Id = Convert.ToInt32(leitor["id_pro"]);
                    processo.Numero = leitor["numero_pro"].ToString();
                    processo.Data = Convert.ToDateTime(leitor["data_pro"]);
                    processo.Interessado = leitor["interessado_pro"].ToString();
                    processo.Assunto = leitor["assunto_pro"].ToString();
                    processo.Descricao = leitor["descricao_pro"].ToString();
                    processo.Situacao = leitor["situacao_pro"].ToString();

                    lista.Add(processo);
                }

                return lista;
            }
            catch
            {
                throw;
            }
        }
    }
}