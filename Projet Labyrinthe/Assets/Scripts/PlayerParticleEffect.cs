using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticleEffect : MonoBehaviour
{
   public GameObject character; // Référence à votre personnage

    private ParticleSystem particleSystem; // Référence au Particle System

     private bool isParticleSystemPlaying = false; 

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (character != null)
        {
            // print pour débug la vitesse du joueur
            //print(character.GetComponent<Rigidbody>().velocity.magnitude);
            // Vérifie si la vitesse du joueur est supérieur à un seuil
            if (character.GetComponent<Rigidbody>().velocity.magnitude > 3f)
            {
                if (!isParticleSystemPlaying)
                {
                    // Activer le Particle System
                    particleSystem.Play();
                    isParticleSystemPlaying = true;
                }
            }
            else
            {
                 // Vérifier si le Particle System est en cours de lecture
                if (isParticleSystemPlaying)
                {
                    // Désactiver le Particle System
                    particleSystem.Stop();
                    //particleSystem.Clear(); no need
                    isParticleSystemPlaying = false;
                }
            }
            // Déplacer le système de particules vers la position du personnage
            transform.position = character.transform.position;
        }
    }
}
