using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detta : MonoBehaviour
{
 
    public void FixedUpdate()
    {
        if (transform.position.y <= -25) // endurr�sir senuni ef player dettur undir -25
        {
            Endurr�sa();
        }
    }

    public void Endurr�sa()// endurr�sir senuna 
    {
        SceneManager.LoadScene(1);
    }
}
