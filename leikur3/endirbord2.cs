using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endirbord2 : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player")// ef player labbar � coliider keyrir �essi if 
        {
            SceneManager.LoadScene(3);//hle�ur senu 3
            Debug.Log("ok");
        }
    }
}
