using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaCollision : MonoBehaviour
{
    public GameObject dialogue;
    
    private void OnTriggerEnter(Collider col)
    {
        dialogue.SetActive(true);
        MonDéplacement.isTalking = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    private void OnTriggerExit(Collider col)
    {
        dialogue.SetActive(false);
        MonDéplacement.isTalking = false;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
}



