using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float speedMultiplier = 1.5f; // Facteur de multiplication de la vitesse
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Vérifie si la collision implique le personnage
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                playerRigidbody.velocity *= speedMultiplier; // Multiplie la vitesse actuelle du personnage par le facteur de multiplication
            }
        }
    }
}