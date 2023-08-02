using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public float invisibilityTime = 1f;

    public HealthBar healthBar;
    
    private float timer = 0f;
    private bool TakeDamage = true;


    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {
        if(!TakeDamage)
        {
            timer += Time.deltaTime;
            if(timer>=invisibilityTime){
                TakeDamage = true;
                timer = 0f;
            }
        }
    }

    public void DamagePlayer( int damage )
    {
        if (TakeDamage){
            TakeDamage = false; //invisibility mode
            curHealth -= damage;

            healthBar.SetHealth( curHealth );
            if ( curHealth <= 0 )
            {
                Die();
            }
        }

    }

     void Die(){
        Debug.Log("Player died");
     }
}