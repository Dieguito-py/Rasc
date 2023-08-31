using UnityEngine;

public class TargetTracker : MonoBehaviour
{
    private Terrain terrain;
    private TerrainCollider terrainCollider;

    private void Start()
    {
        terrain = GetComponent<Terrain>();
        terrainCollider = GetComponent<TerrainCollider>();

        if (terrain == null || terrainCollider == null)
        {
            Debug.LogWarning("Terrain or Terrain Collider component not found!");
            enabled = false; 
        }
    }

    private void Update()
    {
        if (terrainCollider.enabled && !terrain.enabled)
        {
            terrain.enabled = true;
        }
        else if (!terrainCollider.enabled && terrain.enabled)
        {
            terrain.enabled = false;
        }
    }
}
