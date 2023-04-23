using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttachSlideRandom : MonoBehaviour
{
    float randomNumber;
    List<GameObject> platformsWithSlideMovement = new List<GameObject>();

    private void Start()
    {
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");
        foreach (GameObject platform in platforms)
        {
            randomNumber = Random.Range(0, 100);
            if (randomNumber % 7 == 0)
            {
                platform.AddComponent<SlideMovement>();
                platformsWithSlideMovement.Add(platform);
            }
        }
    }

    private void OnDisable()
    {
        foreach (GameObject platform in platformsWithSlideMovement)
        {
            if (platform)
            {
                SlideMovement slideMovement = platform.GetComponent<SlideMovement>();
                if (slideMovement != null)
                {
                    Destroy(slideMovement);
                }
            }
        }
        platformsWithSlideMovement.Clear();
    }
}
