using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject platformPrefab;
    private Camera mainCamera;
    private float cameraHeight;
    private float cameraWidth;
    [SerializeField] int numOfPlatforms = 100;

    private void Awake()
    {
        mainCamera = Camera.main;
        cameraHeight = mainCamera.orthographicSize * 2;
        cameraWidth = cameraHeight * mainCamera.aspect;
    }

    void Start()
    {
        for (int i = 0; i < numOfPlatforms; i++)
        {
            float randomX = Random.Range(-cameraWidth / 2, cameraWidth / 2);
            float randomY = Random.Range(0.5f,200f);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Destroy(other.gameObject);
        }
    }


}
