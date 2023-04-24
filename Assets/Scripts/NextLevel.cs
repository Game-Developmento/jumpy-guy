using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] string nextScene;

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(nextScene);
    }

}
