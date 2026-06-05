using System.ComponentModel.DataAnnotations;

public class ImcModel
{
    [Required(ErrorMessage = "Peso é obrigatório")]
    [Range(1, 500, ErrorMessage = "Peso deve ser entre 1 e 500 kg")]
    public double Peso { get; set; }

    [Required(ErrorMessage = "Altura é obrigatória")]
    [Range(0.5, 3.0, ErrorMessage = "Altura deve ser entre 0.5 e 3.0 m")]
    public double Altura { get; set; }

    public double? Resultado { get; set; }
    public string? Classificacao { get; set; }
}
