using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();
    Carro gol = new Carro();
    
    Caminhao caminhao = new Caminhao();

    void Start()
    {
        fusca.AtribuirNome("Fusca do Pai");
        fusca.AtribuirCor("Amarelo");
        fusca.AtribuirNumeroDeRodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log( "0 " + fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() + " tem " + fusca.NumeroDeRodas() +
                   " e o preco R$" + fusca.Preco());

        gol.AtribuirNome("Gol do Falstão");
        gol.AtribuirCor("Verde");
        gol.AtribuirNumeroDeRodas(4);
        gol.AtribuirPreco(3000.00f);
        Debug.Log("O " + gol.NomeDoCarro());
        
        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumeroDeRodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul" );
        caminhao.AtribuirNome("Caminhao do Falstão");
        
        //fusca.AtribuirTipoDeCarroceria("Larga);

        if (fusca.ComparePreco(caminhao))
        {
            
        }
        
        
        

        if (fusca.ComparePreco(gol))
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O Carro " + fusca.NomeDoCarro() + " é mais barato do que o carro " + gol.NomeDoCarro());
        }
        
    }

    void Update()
    {
        
    }
}