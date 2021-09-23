
namespace SoPiadas.Models;
public class Piada
{
    public int Id { get; set; }
    public string Pergunta { get; set; }
    public string Resposta { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public Piada()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        
    }
}
