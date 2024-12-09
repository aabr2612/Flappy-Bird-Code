using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public AudioSource addScoreAudio;
    public AudioSource gameOverAudio;
    public AudioSource gameBackGroundAudio;
    public GameObject gameOverScreen;
    public void AddScore()
    {
        playerScore=playerScore+1;
        scoreText.text = "Score: " + playerScore.ToString();
        addScoreAudio.Play();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameBackGroundAudio.Play();
    }
    public void GameOver()
    {
        gameOverAudio.Play();
        gameBackGroundAudio.Pause();
        gameOverScreen.SetActive(true);
    }
}
