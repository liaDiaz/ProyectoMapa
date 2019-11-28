using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor9 : MonoBehaviour
{
      public Transform reproductorEnemgo9Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo9", 45, 1); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo9(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo9Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
