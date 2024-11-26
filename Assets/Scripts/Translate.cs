using UnityEngine;

public class Translate : MonoBehaviour
{
    public float speed;
    public float gravedad;


    //QUIERO MOVER UNA ESFERA SIN METERLE EL SCRIPT
    [SerializeField] GameObject objeto;


    void Start()
    {

    }


    void Update()
    {
        //COMO LO MOVEMOS EN X,Y,Z
        Vector3 despl = new Vector3(0, 0, 0);

        
        //LA ACCION DE MOVERLO
        transform.Translate(Vector3.up* Time.deltaTime * speed);
        objeto.transform.Translate(Vector3.up * Time.deltaTime * speed);

        //SACAMOS LA POSICION DEL OBJETO POR LA CONSLA
        float PosX = objeto.transform.position.x;
        float PosY = objeto.transform.position.y;

        transform.Translate(Vector3.down * gravedad * Time.deltaTime);

        if (transform.position.y > -1)
        {
            gravedad = 0;
        }


        else
        {
            gravedad = -1;
        }


    }





    
}
