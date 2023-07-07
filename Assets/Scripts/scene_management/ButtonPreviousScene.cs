using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPreviousScene : MonoBehaviour
{
    public void LoadPreviousScene()
    {
        int currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneBuildIndex - 1);
    }
}
