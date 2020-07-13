using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour {

    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Car[] carPrefabArray;

    bool spawn = true;

    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnCar();
        }
    }

    private void SpawnCar()
    {
        var carIndex = Random.Range(0, carPrefabArray.Length);
        Spawn(carPrefabArray[carIndex]);
    }

    private void Spawn (Car myCar)
    {
        Car newCar = Instantiate(myCar, transform.position, transform.rotation) as Car;
        newCar.transform.parent = transform;
    }
}