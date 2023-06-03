using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipArrowScript : MonoBehaviour
{
    public string sceneName;

    public void SkipIntro()
    {
        SceneManager.LoadScene(sceneName);
    }
}