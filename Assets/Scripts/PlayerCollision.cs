using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("we hit " + collision.collider.name);

            // Disable the entire script upon colliding with an Obstacle
            movement.enabled = false;
        }
    }
}
