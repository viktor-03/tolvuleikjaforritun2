using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class byrjunTakki : MonoBehaviour
{
    private void Update()
    {
        Cursor.visible = true;// gerir m�sina sj�anlega
        Cursor.lockState = CursorLockMode.None;
    }

    public void Byrja()// hle�ur inn senu 1
    {
        SceneManager.LoadScene(1);
    }

    public void Endir()// hle�ur inn senu 0
    {
        SceneManager.LoadScene(0);
    }

}
