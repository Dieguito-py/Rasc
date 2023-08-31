using UnityEngine;
using UnityEngine.UI;

public class TerrainAndImageController : MonoBehaviour
{
    public Terrain terrain;
    public RawImage rawImage;

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
        if (!terrain.enabled && !imageScheduled)
        {
            imageScheduled = true;
            Invoke("ShowRawImage", 5f); 
        }
        else if (terrain.enabled && rawImage.enabled)
        {
            rawImage.enabled = false;
        }
    }

    private void ShowRawImage()
    {
        rawImage.enabled = true;
        imageScheduled = false;
    }
}
