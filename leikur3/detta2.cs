 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detta2 : MonoBehaviour
{
    public void FixedUpdate()
    {
        if (transform.position.y <= -35)// endurręsir senuni ef player dettur undir -25
        {
            Endurręsa();
        }
    }

    public void Endurręsa()// endurręsir senuna 
    {
        SceneManager.LoadScene(2);
    }
}
