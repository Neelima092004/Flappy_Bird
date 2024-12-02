using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playscore;
    public Text scoreText;
    public AudioSource dingSFX;
    public GameObject gameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore(int addsc)
    {
        playscore += addsc;
        scoreText.text= playscore.ToString();
        dingSFX.Play();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);    
    }
}
