﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D rb; // ссылка на компонент

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); // находим и получаем ссылку на "соседний" компонент объекта
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce((Vector2.up + Vector2.right) * 300f);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * 300f);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector2.left * 300f);
        }
    }
}
/*
 * Установить Unity
 * Создать 2D проект
 * Создать главный персонаж (Flappy Bird)
 * Реализовать ограничения движения персонажа границами видимости камеры
 */
