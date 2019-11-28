using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor5 : MonoBehaviour
{
    // Start is called before the first frame update
      public Transform reproductorEnemgo5Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo5", 20, 35); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo5(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo5Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
