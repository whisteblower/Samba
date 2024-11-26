using UnityEngine;

public class Impulse : MonoBehaviour
{
    [SerializeField] GameObject nave;
    [SerializeField] float force;
    [SerializeField] float flyForce;
    [SerializeField] float torsionY;
    private Rigidbody rb;

  
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.right * force, ForceMode.Acceleration);
            rb.AddRelativeForce(Vector3.up * flyForce, ForceMode.Acceleration); 

        }

        float torsionY = Input.GetAxis("Horizontal");
        rb.AddTorque(0, torsionY, 0);




    }







}
