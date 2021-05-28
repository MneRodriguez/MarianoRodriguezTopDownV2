using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCam : MonoBehaviour
{
    public GameObject Jugador;
    public Vector2 offset;
    public float movtoCam = 0.5f;

    void Start()
    {
        offset = transform.position + Jugador.transform.position;
    }

    
    void Update()
    {
        Vector2 posDeCam = Jugador.transform.TransformPoint(new Vector3(-1f, -1f, -10f));
        transform.position = Vector2.SmoothDamp(transform.position, posDeCam, ref offset, movtoCam);
    }
}
