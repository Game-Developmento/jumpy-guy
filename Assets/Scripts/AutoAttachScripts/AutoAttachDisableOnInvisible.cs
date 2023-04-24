using UnityEngine;

public class AutoAttachDisableOnInvisible : MonoBehaviour
{
    private void Start()
    {
        // Find all platform objects in the scene
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");

        // Attach the DisableOnInvisible script to each platform object
        foreach (GameObject platform in platforms)
        {
            if (platform.GetComponent<DisableOnInvisible>() == null)
            {
                platform.AddComponent<DisableOnInvisible>();
            }
        }
    }
}
