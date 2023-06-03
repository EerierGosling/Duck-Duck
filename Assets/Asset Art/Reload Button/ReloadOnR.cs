using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnR : MonoBehaviour
{
    void Update()
{
    if (Input.GetKeyDown(KeyCode.R))
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
}
