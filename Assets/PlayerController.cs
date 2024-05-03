using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del tanque (ajusta según sea necesario)
    private Rigidbody rb;
    private Vector3 moveDirection = Vector3.forward; // Dirección inicial de movimiento (hacia adelante)

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Verificar si alguna tecla de movimiento está presionada
        bool isMoving = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) ||
                        Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) ||
                        Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) ||
                        Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        // Si alguna tecla de movimiento está presionada, aplicar movimiento hacia adelante
        if (isMoving)
        {
            // Aplicar movimiento en la dirección actual del tanque
            rb.velocity = moveDirection * moveSpeed;
        }
        else
        {
            // Si no se presiona ninguna tecla de movimiento, detener el movimiento
            rb.velocity = Vector3.zero;
        }
    }

    void Update()
    {
        // Rotar el tanque según la tecla presionada
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            // Rotar hacia arriba (0 grados) y establecer la dirección de movimiento hacia adelante
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            moveDirection = Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            // Rotar hacia la derecha (90 grados) y establecer la dirección de movimiento hacia la derecha
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            moveDirection = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            // Rotar hacia la izquierda (-90 grados) y establecer la dirección de movimiento hacia la izquierda
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            moveDirection = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            // Rotar hacia abajo (180 grados) y establecer la dirección de movimiento hacia atrás
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            moveDirection = Vector3.back;
        }
    }
}
