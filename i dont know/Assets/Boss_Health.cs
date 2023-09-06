using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Health : MonoBehaviour
{
    public int maxHealth = 500;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <=0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("BIG MICE GOT SLICE AND DICED LMAO");
    }
}
