using UnityEngine;

public class RotateMoon : MonoBehaviour
{
    public Transform moon;
    public float erthSpeed = 10f, moonSpeed = 15f;

    private void Update()
    {
        transform.Rotate(Vector3.up * erthSpeed * Time.deltaTime);
        moon.RotateAround(transform.position, Vector3.up, moonSpeed * Time.deltaTime);
    }
}
