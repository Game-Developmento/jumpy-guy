using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] public float minVelocityX;
    [SerializeField] public float maxVelocityX;

    private float velocity;
    [SerializeField] public float minTimeBetweenSpawns;
    [SerializeField] public float maxTimeBetweenSpawns;
    private float secondsBetweenSpawns;

    GameObject newObject;

    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            newObject = Instantiate(prefabToSpawn.gameObject, transform.position, Quaternion.identity);
            velocity = Random.Range(minVelocityX, maxVelocityX);
            Vector3 velocityOfSpawnedObject = new Vector3(velocity, 0, 0);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
            secondsBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(secondsBetweenSpawns);
        }
    }

}
