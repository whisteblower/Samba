using UnityEngine;

public class interactividad : MonoBehaviour
{

    [SerializeField] GameObject bala;
    [SerializeField] Transform referencia;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bala, referencia.position, Quaternion.identity);
        }
    }
}
