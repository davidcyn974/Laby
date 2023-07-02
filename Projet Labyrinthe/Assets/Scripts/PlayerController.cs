using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 80f;
    public float gravity = 30f;

    private float xInput;
    private float yInput;

    public float ejectForce = 45f; // La force d'éjection vers le haut

    //private Animator animator;
    public Material defaultMaterial;
    public Material newMaterial;
    private Renderer renderer;
    private bool isBoostActive = false;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //animator = GetComponent<Animator>();
        renderer = GetComponent<Renderer>();
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
        if (other.CompareTag("JumpPlatform"))
        {
            // Applique une force vers le haut pour éjecter le personnage
            rb.AddForce(Vector3.up * ejectForce, ForceMode.Impulse);
        }
        // Cas où c'est une plateforme de vitesse
        else if (other.CompareTag("SpeedPlatform"))
        {
            
            // Get SpeedPlatform and destroy it
            Destroy(other.gameObject);
            Vector3 currentSize = rb.transform.localScale;

            // Modifier la taille du personnage
            float scaleFactor = 1f; // Facteur d'échelle pour agrandir le personnage
            Vector3 newSize = currentSize * scaleFactor;

            // Appliquer la nouvelle taille au personnage
            transform.localScale = newSize;
            speed += 60f;
           StartCoroutine(PlaySpeedAnimation());
        }
    }
    IEnumerator PlaySpeedAnimation()
    {
         // Activer le boost de vitesse
        speed = 0;
        yield return new WaitForSeconds(3f);
        renderer.material = newMaterial;
        isBoostActive = true;
        speed = 250f;
        // Attendre pendant 8 secondes
        yield return new WaitForSeconds(6f);
        renderer.material = defaultMaterial;
        yield return new WaitForSeconds(0.5f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.5f);
        renderer.material = defaultMaterial;
        yield return new WaitForSeconds(0.5f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.5f);
        renderer.material = defaultMaterial;
        yield return new WaitForSeconds(0.5f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.5f);
        renderer.material = defaultMaterial;
        yield return new WaitForSeconds(0.5f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.25f);
        renderer.material = defaultMaterial;
        yield return new WaitForSeconds(0.25f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.25f);
        renderer.material = defaultMaterial;
        yield return new WaitForSeconds(0.1f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.1f);
        renderer.material = defaultMaterial;
         yield return new WaitForSeconds(0.1f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.1f);
        renderer.material = defaultMaterial;
         yield return new WaitForSeconds(0.1f);
        renderer.material = newMaterial;
        yield return new WaitForSeconds(0.1f);
        renderer.material = defaultMaterial;

        // Désactiver le boost de vitesse
        isBoostActive = false;
        speed = 75f;
    }
}






