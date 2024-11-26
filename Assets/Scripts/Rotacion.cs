using UnityEngine;

public class Rotacion : MonoBehaviour
{

    public float giro;
    public Vector3 Vector3;



    void Start()
    {

    }


    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * giro);
       

    }
}
