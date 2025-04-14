using UnityEngine;

public class Teste : MonoBehaviour
{
    private Carro fusca = new Carro();
    void Start()
    {
        fusca.AtribuirNome("Fusca do Pai");
        Debug.Log("0" + fusca.NomeDoCarro());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
