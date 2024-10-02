using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
