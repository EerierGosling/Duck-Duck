using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeUi : MonoBehaviour
{
    public string sceneName;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
