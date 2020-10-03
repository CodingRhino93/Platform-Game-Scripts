using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public GameObject playerDeathEffect;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        GameObject deathEffectAnim = Instantiate(playerDeathEffect, transform.position, Quaternion.identity);
        Destroy(deathEffectAnim, 0.35f);
        Destroy(gameObject);
        FadeOut();
    }

    public void FadeOut()
    {
        animator.SetTrigger("FadeOutDeath");
    }

    public void GameOverMenu()
    {
        SceneManager.LoadScene("GameOver");
    }
}
