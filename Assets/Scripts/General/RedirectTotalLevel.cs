using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirectTotalLevel : MonoBehaviour
{
    public static int redirectTolLevel;

    void Update()
    {
        if (redirectTolLevel == 3)
        {
            SceneManager.LoadScene(redirectTolLevel);
        }
        if (redirectTolLevel == 4)
        {
            SceneManager.LoadScene(redirectTolLevel);
        }
    }
}
