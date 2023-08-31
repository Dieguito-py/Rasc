using UnityEngine;
using UnityEngine.UI;

public class TerrainController : MonoBehaviour
{
    public Terrain terrain;
    public RawImage rawImage;
    public float displayTime = 5f;

    private bool terrainActive = false;
    private bool imageScheduled = false;

    private void Start()
    {
        if (terrain == null)
        {
            Debug.LogWarning("Terrain component not found!");
            enabled = false; 
        }
        else
        {
            rawImage.enabled = false; 
        }
    }

    private void Update()
    {
        if (terrain.enabled && !terrainActive)
        {
            terrainActive = true;
            imageScheduled = true;
            Invoke("ShowRawImage", displayTime);
        }
        else if (!terrain.enabled && terrainActive)
        {
            terrainActive = false;
            rawImage.enabled = false;
            imageScheduled = false;
            CancelInvoke("ShowRawImage");
        }
    }

    private void ShowRawImage()
    {
        if (imageScheduled)
        {
            rawImage.enabled = true;
            imageScheduled = false;
            Invoke("HideRawImage", displayTime);
        }
    }

    private void HideRawImage()
    {
        rawImage.enabled = false;
    }
}
