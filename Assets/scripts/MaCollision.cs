using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaCollision : MonoBehaviour
{
    public GameObject dialogue; //choisit l'objet à faire apparaitre (ici on prend le canvas)
    
    private void OnTriggerEnter(Collider col) // détecte "l'appui" sur le cylindre
    {
        dialogue.SetActive(true); // fait apparaitre la boite de dialogue (ici le canvas)
        MonDéplacement.isTalking = true; // bloque le mouvement de camera
        Cursor.lockState = CursorLockMode.None; //permet de pouvoir utiliser sa souris
        Cursor.visible = true; // affiche le curseur de la souris
    }
    private void OnTriggerExit(Collider col)
    {
        dialogue.SetActive(false);
        MonDéplacement.isTalking = false; // débloque le mouvement de camera
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false; // cache le curseur de la souris
    }
}



