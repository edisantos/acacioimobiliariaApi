using System;

namespace lemosinfotec.acaciovistorias.domain.Entities
{
    public class Imobiliarias
    {
        public int ImobiliariaId { get; set; }
        public DateTime DataRegistros { get; set; } 
        public string ImobiliariaNome { get; set; }     
        public string Endereco { get; set; }    
        public int Numero { get; set; } 
        public string Bairro { get; set; }  
        public string Cidade { get; set; }  
        public string uf { get; set; }
        public string Cnpj { get; set; }
        public string Cep { get; set; }
    }
}
