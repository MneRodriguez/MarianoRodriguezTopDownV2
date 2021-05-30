using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBalaJgdr : MonoBehaviour
{   
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            
        }
    }
}
