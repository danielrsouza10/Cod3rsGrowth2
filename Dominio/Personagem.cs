namespace Dominio;

public class Personagem
{
    private int id;
    private string nome;
    private int idRaca;
    private enum classe
    {
        Arqueiro,
        Guerreiro,
        Mago,
        Ladrao,
        Curandeiro
    }
    private int idade;
    private decimal altura;
    private decimal peso;
    private DateTime dataDoCadastro;
}