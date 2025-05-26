using System;
using UnityEngine;

public class testeDeDano : MonoBehaviour
{
    private Personagem personagem;
    
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Inimigo"))
        {
           int energiaAtual = personagem.Energia()
                                - colisao.gameObject.GetComponent<Inimigo>().DanoDoInimigo();
           
            personagem.AtribuirEnergia(energiaAtual);
           
            Debug.Log("O personagem " +personagem.Nome()+" tem agora "+personagem.Energia());
        }
    }

    void Start()
    {
        personagem = GetComponent<Personagem>();
    }

  
    void Update()
    {
     
    }
}