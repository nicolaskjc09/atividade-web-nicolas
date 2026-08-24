using System.Globalization;

namespace SindromeDe.DAO
{
    public class Processo
    {
        public int Id { get; set; }

        public string Numero { get; set; } = string.Empty;

        public DateOnly Data { get; set; }

        public string Interessado { get; set; } = string.Empty;

        public string Assunto { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public string Situacao { get; set; } = string.Empty;

    }
}

/*CREATE TABLE processos (
	id_pro INT NOT NULL AUTO_INCREMENT,
    numero_pro VARCHAR(200) NOT NULL, 
    data_pro DATE NOT NULL,
    interessado_pro VARCHAR(200) NOT NULL, 
    assunto_pro VARCHAR(300) NOT NULL,
    descricao_pro TEXT NULL,
    situacao_pro VARCHAR(50) NOT NULL DEFAULT "Aberto",
    
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    
    PRIMARY KEY(id_pro)
);

*/