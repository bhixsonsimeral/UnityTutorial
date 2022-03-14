using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidbody;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    // We use FixedUpdate as it is prefered when dealing with physics

    // When checking for player input, we should instead do this in Update()
    // FixedUpdate has the possibilty of running slower and missing an input
    // This would normally be handled by checking for player input and storing
    // it in a variable of some sort (potentially the boolean moveRight)
    void FixedUpdate()
    {
        // Time.deltaTime is the amount of time since the last frame
        // Add a forward force
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Input.GetKey is limited as it will not work with a controller
        // This implementation also does not allow for substitute keys
        if (Input.GetKey("d") )
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
