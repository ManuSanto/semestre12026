using UnityEngine;

public class NewMonoBehaviorScript :MonoBehavior
{
  private GameObject_player;
  private Rigidbody_rigidboby;
  private float velocidade;

  public float raioDeVisao = false;

  private SphereCollider_sphereCollider;




  void Start()
  {
    _rigidboby = GameObject.GetComponent<Rigidbody>();
  }





}
