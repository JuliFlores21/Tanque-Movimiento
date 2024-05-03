using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DireccionTanque : MonoBehaviour
{
    public Transform Tanque; // Referencia al objeto tanque que contiene al cañón

    // Grados de rotación para cada dirección
    public float rotacionArriba = 0f;
    public float rotacionDerecha = 90f;
    public float rotacionIzquierda = -90f;
    public float rotacionAbajo = 180f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            Tanque.rotation = Quaternion.Euler(0f, 0f, rotacionArriba);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Tanque.rotation = Quaternion.Euler(0f, 0f, rotacionDerecha);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            Tanque.rotation = Quaternion.Euler(0f, 0f, rotacionIzquierda);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Tanque.rotation = Quaternion.Euler(0f, 0f, rotacionAbajo);
        }
    }
}