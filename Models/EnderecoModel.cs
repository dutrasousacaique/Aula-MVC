using System.ComponentModel.DataAnnotations;

public class EnderecoModel
{
    [Required(ErrorMessage = "CEP é obrigatório")]
    public string CEP { get; set; }

    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string UF { get; set; }
}
