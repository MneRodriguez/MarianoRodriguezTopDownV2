using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoEnemigo : MonoBehaviour
{
    public GameObject ObjSpriteDelEnem;
    void Start()
    {
        ObjSpriteDelEnem = GetComponent<GameObject>();
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BalaJugador"))
        {
            Destroy(ObjSpriteDelEnem);
        }
    }
}
