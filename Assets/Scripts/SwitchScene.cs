using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string sceneName;
    public Manager Man;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Man.openDoor) {
            SceneManager.LoadScene(sceneName);
        }
    }
}
