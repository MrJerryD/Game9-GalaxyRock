using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    public GameObject pauseGameMenu;
    public GameObject puaseBtn; // скрываем кнопку паузы

    public AudioSource audioSource; // для музыки на фоне
    public AudioSource audioHit; // для музыки при ударе
    public AudioSource audioFind; // для музыки при find комету

    public Text text;
    private float komeyFind = 0;

    private bool gameStopped = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !gameStopped)
        {
            StopGame();
        }
        else if (collision.gameObject.CompareTag("Enemy") && gameStopped)
        {
            RestartGame();
        }

        if (collision.gameObject.CompareTag("Find"))
        {
            Destroy(collision.gameObject); // уничтожаем обьект
            if (!audioFind.isPlaying)
            {
                audioFind.Play();
            }
            if (collision.gameObject.tag == "Find")
            {
                komeyFind++;
                UpdateCountText();
                Destroy(collision.gameObject);
            }
        }
        void UpdateCountText()
        {
            text.text = "X: " + komeyFind;
        }
    }

    void StopGame()
    {
        gameStopped = true;
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f; // Время заморожено
        puaseBtn.SetActive(false);
        audioSource.Stop();
        audioHit.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f; // Восстанавливаем время
        puaseBtn.SetActive(true);
        audioSource.Play();
        audioHit.Stop();
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
