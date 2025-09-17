using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject cuboVerde;
    private Vector3 posicion;
    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(moveHorizontal * speed, 0.0f, moveVertical * speed);

        rb.AddForce(movimiento);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Transportador"))
        {
            transform.position = cuboVerde.transform.position;
        }
        else if (other.gameObject.CompareTag("Reiniciador"))
        {
            transform.position = new Vector3(0, 15, 0);
        }
        else if (other.gameObject.CompareTag("Desplazador"))
        {
            posicion = other.gameObject.transform.position;
            Vector3 suma = new Vector3(-1, 0, 0);
            other.gameObject.transform.position = posicion + suma;
        }
        else
        {
            
        }
        
    }
}
