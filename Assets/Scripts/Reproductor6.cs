﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor6 : MonoBehaviour
{
      public Transform reproductorEnemgo6Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo6", 25, 35); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo6(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo6Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
