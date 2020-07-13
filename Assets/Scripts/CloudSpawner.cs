using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Cloud[] cloudPrefabArray;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnCloud();
        }
    }

    private void SpawnCloud()
    {
        var cloudIndex = Random.Range(0, cloudPrefabArray.Length);
        Spawn(cloudPrefabArray[cloudIndex]);
    }

    private void Spawn(Cloud myCloud)
    {
        Cloud newCloud = Instantiate(myCloud, transform.position, transform.rotation) as Cloud;
        newCloud.transform.parent = transform;
    }
}

