using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject spawner;
    public GameObject prefabToSpawn; 
    public Vector3[] spawnPositions; 

    void Start()
    {
        spawnPositions = new Vector3[]
        {   
            new Vector3 (0, 0, 0),
            new Vector3 (-4.5f, 0, 0),
            new Vector3 (-9, 0, 0),
            new Vector3 (-0, 0, 4),
            new Vector3 (-4.5f, 0, 4),
            new Vector3 (-9, 0, 4)
        };

        SpawnPrefabs();
    }

    void SpawnPrefabs()
    {
        foreach (Vector3 position in spawnPositions)
        {
            GameObject tempBed = Instantiate(prefabToSpawn, position, Quaternion.identity, spawner.transform);
            tempBed.transform.localPosition = position;
        }
    }
}