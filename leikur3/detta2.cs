 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class detta2 : MonoBehaviour
{
    public void FixedUpdate()
    {
        if (transform.position.y <= -35)// endurr�sir senuni ef player dettur undir -25
        {
            Endurr�sa();
        }
    }

    public void Endurr�sa()// endurr�sir senuna 
    {
        SceneManager.LoadScene(2);
    }
}
