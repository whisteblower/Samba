using UnityEngine;

public class MoverForward : MonoBehaviour
{
    [SerializeField] int Speed;
    [SerializeField] GameObject mover;

    void Start()
    {
    }


    void Update()
    {
        mover.transform.Translate(Vector3.right * Time.deltaTime * Speed);
    }
}
