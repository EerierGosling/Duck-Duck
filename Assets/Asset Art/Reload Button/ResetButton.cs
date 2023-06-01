using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public void ResetScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
