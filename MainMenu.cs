using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator animator;

    public Player player;
    
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        animator.SetTrigger("FadeOutGame");
    }
    
    public void BackToMainMenu()
    {
        animator.SetTrigger("FadeOutMenu");
    }

    public void StartGameTrigger()
    {
        SceneManager.LoadScene("Game");
    }

    public void GameOverMenu()
    {
        player.GameOverMenu();
    }

    public void MainMenuStart()
    {
        SceneManager.LoadScene("Menu");
    }
}
