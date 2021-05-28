using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJgdr : MonoBehaviour
{
    public Camera cam;

    public Rigidbody2D rbJgdr;
    public float velMovto = 1.5f;

    void Start()
    {
        rbJgdr = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxisRaw("Horizontal") * velMovto * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * velMovto * Time.deltaTime;

        transform.position = pos;

        var posDeCam = Camera.main.transform.TransformPoint(transform.position);
        var direccion = Input.mousePosition - posDeCam;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angulo, Vector3.forward);
    }
}
