using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlJgdr : MonoBehaviour
{
    public Camera cam;

    public Rigidbody2D rbJgdr;
    public float velMovto = 0.9f;

    void Start()
    {
        rbJgdr = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // Movimiento tradicional del player con WASD
        Vector2 pos = transform.position; 

        pos.x += Input.GetAxisRaw("Horizontal") * velMovto * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * velMovto * Time.deltaTime;

        transform.position = pos;

        // Movimiento 8 direcciones del player con el MOUSE
        var posDeCam = Camera.main.WorldToScreenPoint(transform.position);
        var direccion = Input.mousePosition - posDeCam;
        var angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            SceneManager.LoadScene("MenuRestart");
        }
    }
}
