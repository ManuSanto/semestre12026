using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private Player movimentoPlayer;
    public float velocidadeDaAnimacao = 1;


    void Start()
    {
      movimentoPlayer = gameObject.GetComponent<Player>();
    }
    
    void Update()
        {
            animator.SetBool("Andando", Player.Andando);
            animator.speed  = velocidadeDaAnimacao;
        }
}





