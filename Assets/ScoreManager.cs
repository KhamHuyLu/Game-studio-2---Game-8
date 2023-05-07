using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int scorePerSlice = 100; // The score awarded for slicing a cube
    public TextMeshProUGUI scoreText; // The TextMeshPro UI element that displays the score

    private int score = 0; // The current score

    // Called when a cube is sliced
    public void OnSliceCube()
    {
        // Increment the score by the scorePerSlice value
        score += scorePerSlice;

        // Update the score text
        scoreText.text = "Score: " + score.ToString();
    }
}