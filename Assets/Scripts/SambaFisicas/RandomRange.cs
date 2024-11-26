using UnityEngine;

public class RandomRange : MonoBehaviour
{
    //CREO UN ARRAY DE TIPO GAMEOBJECT 
    [SerializeField] GameObject[] assets = new GameObject[1];

    //CREAMOS UN VECTOR DE POSICI�N 
        Vector3 initPos;
    void Start()
    {

        //Debug.Log(myArray[0]);
        Debug.Log(Random.Range(0, 10));

        //CREAMOS 7 ELEMENTOS EN BASE A UNA POSICI�N Y ROTACI�N DADAS 
        for (int i = 0; i < assets.Length; i++)
        {

            //RANDOM RANGE
            int r = Random.Range(0, assets.Length);

            Instantiate(assets[r], initPos, Quaternion.Euler(0, 180, 0));
            //LOS SEPARAMOS UNOS DE OTROS SUMANDO UN NUEVO VECTOR
            initPos = initPos + new Vector3(0, 0, 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        initPos = transform.position;
    }
}