using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private string energia;
    private string forca_ataque;
    private string forca_do_pulo;
    private string velocidade;
    private string numero_de_pes;
    private string numero_de_maos;


    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string atribuirenergia(string energia)
    {
        return this.nome;
    }

    public void Atribuirforca_ataque(string forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public string atribuirforca_do_pulo(string forca_do_pulo)
    {
        return this.forca_do_pulo;
    }

    public void atribuirvelocidade(string velocidade)
    {
        this.velocidade = velocidade;
    }

    public void atribuirnumero_de_pes(string numero_de_pes)
    { 
        this.numero_de_pes = numero_de_pes;
    }

    public void atribuirnumero_de_maos(string numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }
    
    
    
}

