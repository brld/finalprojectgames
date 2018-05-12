// Some of this script is thanks to Unity3d documentation and also thanks to DukeLaze

using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 25.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*(rb.mass*10));
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            rb.AddForce(Vector3.up*(rb.mass*-10));
        }
    }
}