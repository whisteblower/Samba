using UnityEngine;

public class CamaraMover : MonoBehaviour
{
    public Transform nave;
    public Vector3 offset;
    void Start()
    {
        offset = transform.position - nave.position;
    }

    void LateUpdate()
    {
        transform.position = nave.position + offset;
    }
}