using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endir : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "Player")// ef player labbar á coliider keyrir þessi if 
        {
            SceneManager.LoadScene(2);//hleður senu 3
            Debug.Log("ok");
        }
    }
 
}
