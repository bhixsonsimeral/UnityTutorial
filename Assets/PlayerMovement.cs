using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // We use FixedUpdate as it is prefered when dealing with physics
    void FixedUpdate()
    {
        // Time.deltaTime is the amount of time since the last frame
        rigidbody.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
