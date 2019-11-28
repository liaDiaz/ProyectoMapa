using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor2 : MonoBehaviour
{
      public Transform reproductorEnemgo2Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo2", 10, 35); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo2(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo2Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
