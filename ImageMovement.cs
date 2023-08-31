using UnityEngine;

public class ImageMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float moveDistance = 5f; 

    private float initialX; 

    private void Start()
    {
        initialX = transform.position.x;
    }

    private void Update()
    {
        float newX = initialX + Mathf.PingPong(Time.time * moveSpeed, moveDistance * 2f) - moveDistance;

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
