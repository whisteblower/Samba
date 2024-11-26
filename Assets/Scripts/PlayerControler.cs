using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public float rota;

    void Start()
    {
        
    }


    void Update()
    {
        //MOVER EN EL EJE X 
        float desplX = Input.GetAxis("Horizontal");
        //GET AXIS LOS NÚMEROS VAN DE -1 A +1 
        Debug.Log(Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.right * desplX * Time.deltaTime * speed);

        //MOVER EN EL EJE Y 
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * desplY * Time.deltaTime * speed);

        //Giros
        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rota);

        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(Vector3.back * Time.deltaTime * rota);
        }


        //LIMITES
        float PosX = (transform.position.x);
        float PosY = (transform.position.y);
        float PosZ = (transform.position.z);

        if (PosX > 20 || PosY < -20 || PosY > 20 || PosY < -20 || PosY > 20 || PosZ < -20)
        {
            transform.position = Vector3.zero;
        }


    }
}
