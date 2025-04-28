using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private string energia;
    [SerializeField]
    private string forca_ataque;
    [SerializeField]
    private string forca_do_pulo;
    [SerializeField]
    private string velocidade;
    [SerializeField]
    private string numero_de_pes;
    [SerializeField]
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

