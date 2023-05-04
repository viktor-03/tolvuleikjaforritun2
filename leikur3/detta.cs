using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detta : MonoBehaviour
{
 
    public void FixedUpdate()
    {
        if (transform.position.y <= -25) // endurræsir senuni ef player dettur undir -25
        {
            Endurræsa();
        }
    }

    public void Endurræsa()// endurræsir senuna 
    {
        SceneManager.LoadScene(1);
    }
}
