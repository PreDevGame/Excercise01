using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{

    public void Level_1()
    {
        SceneManager.LoadScene(3);
        ResetOldScore();
    }

    public void Level_2()
    {
        SceneManager.LoadScene(4);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetOldScore()
    {
        GlobalScore.currentScore = 0;
    }
}
