using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneBuildIndex + 1);
    }
}
