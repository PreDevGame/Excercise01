using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject levelAudio;
    public GameObject fadeOut;
    public AudioSource gameOver;

    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
        gameOver.Play();
    }

    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        levelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
        GlobalScore.currentScore = 0;
    }
}
