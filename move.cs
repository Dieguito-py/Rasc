using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public Slider slider;
    public float movementSpeed = 5f;
    public float minY = 0f;
    public float maxY = 10f;

    private void Update()
    {
        float targetY = Mathf.Lerp(minY, maxY, slider.value);
        Vector3 targetPosition = new Vector3(transform.position.x, targetY, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
    }
}
