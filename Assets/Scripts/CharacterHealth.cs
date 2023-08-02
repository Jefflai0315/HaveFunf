using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    
    public Image healthBarFill;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthBar()
    {
        float fillAmount = (float)currentHealth / maxHealth; // find percentage of health
        healthBarFill.fillAmount = fillAmount;
    }

    private void Die()
    {
        // Implement what happens when the character dies
        // For example, you can deactivate the GameObject or trigger a death animation
        Debug.Log("Character has died!");
    }
}
