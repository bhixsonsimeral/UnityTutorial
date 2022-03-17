using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Using a direct refrence like this means that if the player is
    // ever removed from the scene, the Transform will default to null
    // This can be fixed by finding the specific object that we are
    // looking for.
    public Transform player;
    public Vector3 cameraOffset;
    public float scale;
    // Update is called once per frame
    void Update()
    {
        // This doesn't do exactly what I want, as it zooms along an axis
        // instead of zooming into the player. I would bet there is a built
        // in fuction for doing what I want.
        if (Input.mouseScrollDelta != new Vector2(0, 0))
        {
            // Vector3.forward is a unit vector for the way the object is facing
            // The camera is not facing the player, so this also does not achieve
            // out desired result.
            cameraOffset += Vector3.forward * Input.mouseScrollDelta.y * scale;
        }
        transform.position = player.position + cameraOffset;
    }
}
