using UnityEngine;
using UnityEngine.UI;

public class DeviceMovement : MonoBehaviour
{
    public RawImage image;
    public float stationaryThreshold = 0.1f;
    public float delayTime = 10f;

    private bool imageVisible = true;

    private void Start()
    {
        Invoke("ShowImage", delayTime);
    }

    private void Update()
    {
        float accelerationX = Input.acceleration.x;

        if (Mathf.Abs(accelerationX) <= stationaryThreshold && !imageVisible)
        {
            imageVisible = true;
            Invoke("ShowImage", delayTime);
        }
        else if (Mathf.Abs(accelerationX) > stationaryThreshold && imageVisible)
        {
            imageVisible = false;
            image.enabled = false;
            CancelInvoke("ShowImage");
        }
    }

    private void ShowImage()
    {
        image.enabled = true;
    }
}
