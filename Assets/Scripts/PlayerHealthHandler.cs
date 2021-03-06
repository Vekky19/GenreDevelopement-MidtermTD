﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthHandler : MonoBehaviour
{
    public static PlayerHealthHandler Instance;
    public int health;

    void Start()
    {
        Instance = this;
        health = 5;
    }

    void TakeDamage(int dmg)
    {
        health -= dmg;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }

    void Update()
    {
        if (health <= 0)
        {
            //end game
        }
    }
}
