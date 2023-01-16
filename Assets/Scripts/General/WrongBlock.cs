using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongBlock : MonoBehaviour
{
    public GameObject theWrongBLock;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(theWrongBLock, 0.00001f);
        }
        
    }


}
