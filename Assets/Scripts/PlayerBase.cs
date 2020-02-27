using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBase : MonoBehaviour
{
    public float playerHealth = 100;
    
    public void TakeDamage(float damage)
    {
        playerHealth -= damage;
    }

    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }

    void Update()
    {
        if (playerHealth <= 0)
        {
            EndGame();
        }
    }
}
