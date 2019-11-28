using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor8 : MonoBehaviour
{
     public Transform reproductorEnemgo8Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo8", 40, 30); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo8(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo8Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
