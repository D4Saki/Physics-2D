using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Drag your Player object into this slot in the Inspector
    [SerializeField] private Transform playerTransform;
    
    // Offset ensures the camera isn't stuck "inside" the player's 2D sprite
    private Vector3 offset;

    void Start()
    {
        // Calculate the initial distance between camera and player
        offset = transform.position - playerTransform.position;
    }

    // LateUpdate is best for cameras so the player moves first
    void LateUpdate()
    {
        if (playerTransform != null)
        {
            // We only update the X position. 
            // Y and Z stay at the camera's original values.
            transform.position = new Vector3(
                playerTransform.position.x + offset.x, 
                transform.position.y, 
                transform.position.z
            );
        }
    }
}