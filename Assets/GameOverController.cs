using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject scorePanel;

    private bool hasGameEnded = false;

    void Update()
    {
        if (!hasGameEnded && !audioSource.isPlaying)
        {
            hasGameEnded = true;
            EndGame();
        }
    }

    void EndGame()
    {
        // Show the score panel
        scorePanel.SetActive(true);

        // Stop the game
        Time.timeScale = 0f;
    }
}
