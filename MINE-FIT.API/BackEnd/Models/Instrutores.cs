namespace MINE_FIT.API;
public class Instrutores
{
    public Instrutores(string Nome)
    {
        CriadoEm = DateTime.Now;
        this.Nome = Nome;
        //Guid gera uma ID extremamente aleatório
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string Nome { get; set; } = string.Empty;
//Usa data do notebook atual para gerar uma data
    public DateTime CriadoEm { get; set; }
}
