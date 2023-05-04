using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endirbord2 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player")// ef player labbar á coliider keyrir þessi if 
        {
            SceneManager.LoadScene(3);//hleður senu 3
            Debug.Log("ok");
        }
    }
}
