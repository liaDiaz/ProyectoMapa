using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor4 : MonoBehaviour
{
      public Transform reproductorEnemgo4Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo4", 2, 35); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo4(){
            
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo4Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
