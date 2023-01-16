using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject guideTable;
    void Start()
    {

        RedirectTotalLevel.redirectTolLevel = 3;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        guideTable.SetActive(true);
        yield return new WaitForSeconds(3);
        guideTable.SetActive(false);

    }

}
