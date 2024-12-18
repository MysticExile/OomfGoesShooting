using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public string sceneName0;
    public string sceneName1;
    public string sceneName2;
    public string sceneName3;
    // button handlers for loading every scene
    public void startButton()
    {
        SceneManager.LoadScene(sceneName0);
    }
    public void controls()
    {
        SceneManager.LoadScene(sceneName1);
    }
    public void backtomenu()
    {
        SceneManager.LoadScene(sceneName2);
    }
    public void gameoverscreen()
    {
        SceneManager.LoadScene(sceneName3);
    }
}
