using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelBestScore");
        bestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }
}
