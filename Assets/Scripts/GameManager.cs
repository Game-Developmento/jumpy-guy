using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameObject player;

    public void restartGame()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player)
        {
            PlayerController playerC = player.GetComponent<PlayerController>();
            if (playerC)
            {
                playerC.setRestartGame(true);
                SceneManager.LoadScene("level-1");
            }
        }
    }

}
