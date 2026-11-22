namespace MINE_FIT.API;

public class Maquinas
{
    private string nome;
    private int id;

    private string funcao;
    //Função que retorna a string nome
    public string setNome(string nome)
    {
        this.nome = nome;
        return this.nome;
    }
    //Construtor que utiliza das variaveis privadas para serem usadas em outras partes do código
    public void Maquina(string nome,int id,string funcao)
    {
        this.nome = nome;
        this.id = id;
        this.funcao = funcao; 
    }
}