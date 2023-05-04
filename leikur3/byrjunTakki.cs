using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class byrjunTakki : MonoBehaviour
{
    private void Update()
    {
        Cursor.visible = true;// gerir músina sjáanlega
        Cursor.lockState = CursorLockMode.None;
    }

    public void Byrja()// hleður inn senu 1
    {
        SceneManager.LoadScene(1);
    }

    public void Endir()// hleður inn senu 0
    {
        SceneManager.LoadScene(0);
    }

}
