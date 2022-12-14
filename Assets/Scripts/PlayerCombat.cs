using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    [Header("Health bar UI")]
    [SerializeField] private RawImage heart1, heart2, heart3;
    [SerializeField] private Texture emptyHeart, halfHeart, fullHeart;

    //public but hidden variables
    [HideInInspector] public int currentHealth;

    //private variables
    private readonly int maxHealth = 6;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)
            && currentHealth >= 1)
        {
            TakeDamage(1);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHealthBar();
        Debug.Log("Current Health = " + currentHealth);
    }

    //places hearts to correct positions depending on current health
    private void UpdateHealthBar()
    {
        if (currentHealth == 6)
        {
            heart1.texture = fullHeart;
            heart2.texture = fullHeart;
            heart3.texture = fullHeart;
        }
        else if (currentHealth == 5)
        {
            heart1.texture = fullHeart;
            heart2.texture = fullHeart;
            heart3.texture = halfHeart;
        }
        else if (currentHealth == 4)
        {
            heart1.texture = fullHeart;
            heart2.texture = fullHeart;
            heart3.texture = emptyHeart;
        }
        else if (currentHealth == 3)
        {
            heart1.texture = fullHeart;
            heart2.texture = halfHeart;
            heart3.texture = emptyHeart;
        }
        else if (currentHealth == 2)
        {
            heart1.texture = fullHeart;
            heart2.texture = emptyHeart;
            heart3.texture = emptyHeart;
        }
        else if (currentHealth == 1)
        {
            heart1.texture = halfHeart;
            heart2.texture = emptyHeart;
            heart3.texture = emptyHeart;
        }
        else if (currentHealth == 0)
        {
            heart1.texture = emptyHeart;
            heart2.texture = emptyHeart;
            heart3.texture = emptyHeart;
        }
    }
}