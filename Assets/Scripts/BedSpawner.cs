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
            new Vector3(4, -33, 38),
            new Vector3(1, -33, 38),
            new Vector3(9, -33, 38)
        };

        SpawnPrefabs();
    }

    void SpawnPrefabs()
    {
        foreach (Vector3 position in spawnPositions)
        {
            Instantiate(prefabToSpawn, position, Quaternion.identity, spawner.transform);
        }
    }
}