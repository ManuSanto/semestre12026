using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private int energia;
    [SerializeField]
    private int forca_ataque;
    [SerializeField]
    private int forca_do_pulo;
    [SerializeField] public float velocidade;
    [SerializeField]
    private int numero_de_pes;
    [SerializeField]
    private int numero_de_maos;

    public int Energia()
    {
        return this.energia;
    }
    
    
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public int Forca_Atraque;

    public void atribuirenergia(int energia)
    {
       this.energia = energia;
    }

    
    public void Atribuirforca_ataque(int forca_ataque)
    {
        this.forca_ataque = forca_ataque;
    }

    public int Forca_Ataque()
    {
        return this.Forca_Ataque();
    }

    public void atribuirforca_do_pulo(int forca_do_pulo)
    {
         this.forca_do_pulo = forca_do_pulo;
    }

    
    public void atribuirvelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public void atribuirnumero_de_pes(int numero_de_pes)
    { 
        this.numero_de_pes = numero_de_pes;
    }

    public void atribuirnumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }


    public void AtribuirEnergia(int energiaAtual)
    {
        throw new System.NotImplementedException();
    }

    public string Nome()
    {
        throw new System.NotImplementedException();
    }
}

