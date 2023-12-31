﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    Define.Sounds soundType = Define.Sounds.Food;
    [SerializeField]
    int score = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Managers.Sound.Play(soundType);
            Managers.Game.score += score;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Managers.Sound.Play(soundType);
            Managers.Game.score += score;
            Destroy(gameObject);
        }
    }
}
