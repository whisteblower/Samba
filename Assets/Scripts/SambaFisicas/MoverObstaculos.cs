using UnityEngine;

public class MoverObstaculos : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] GameObject mover;

    void Start()
    {
    }


    void Update()
    {
        mover.transform.Translate(Vector3.left * Time.deltaTime * Speed);
    }
}