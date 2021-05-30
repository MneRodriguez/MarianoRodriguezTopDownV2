using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJgdr : MonoBehaviour
{
    public Transform zonaSpawnDelDisparo;
    public GameObject prefabBalaJgdr;

    public float velDesplzBalaJgdr = 20f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        // ESTA FUNCION DEBE TOMAR LA CANT DE BALAS GENERADAS EN EL POOLING -TODAVIA NO SE COMO-

        GameObject balaJgdr = Instantiate(prefabBalaJgdr, zonaSpawnDelDisparo.position, zonaSpawnDelDisparo.rotation);
        Rigidbody2D rbBala = balaJgdr.GetComponent<Rigidbody2D>();
        rbBala.AddForce(zonaSpawnDelDisparo.right * velDesplzBalaJgdr, ForceMode2D.Impulse);

        //Instantiate(prefabBalaJgdr, zonaSpawnDelDisparo.position, zonaSpawnDelDisparo.rotation);
    }
}
