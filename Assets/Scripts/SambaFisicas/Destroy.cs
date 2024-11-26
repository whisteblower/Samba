using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Nave")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Obstaculo")
        {
            Destroy(other.gameObject);
        }
    }
}

