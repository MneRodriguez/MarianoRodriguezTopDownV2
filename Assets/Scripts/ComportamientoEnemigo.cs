﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoEnemigo : MonoBehaviour
{
    public GameObject Enem;
    public Rigidbody2D rbEnem;
    void Start()
    {
        rbEnem = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BalaJugador"))
        {
            ContadorScore.valorScore += 1;
            Destroy(gameObject);
        }
    }
}
