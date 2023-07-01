using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 10f;
    public float gravity = 30f;

    private float xInput;
    private float yInput;

    public float ejectForce = 45f; // La force d'éjection vers le haut

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Move();
        rb.AddForce(Vector3.down * gravity);
    }

    private void Move()
    {
         rb.AddForce(new Vector3(xInput, 0, yInput) * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si le personnage entre en contact avec le collider de la plateforme
        if (other.CompareTag("SpeedPlatform"))
        {
            // Applique une force vers le haut pour éjecter le personnage
            rb.AddForce(Vector3.up * ejectForce, ForceMode.Impulse);
        }
    }
}






