using UnityEngine;

public class Shootball : MonoBehaviour
{
    public Rigidbody ball;
    private Transform _shootPos;
    public float ballForce = 700f;

    private void Start()
    {
        _shootPos = transform.GetChild(0).transform;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Rigidbody shoot = Instantiate(ball, _shootPos.position, _shootPos.rotation) as Rigidbody;
            shoot.AddForce(_shootPos.forward * ballForce);
        }
    }
}
