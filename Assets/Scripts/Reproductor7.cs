using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor7 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform reproductorEnemgo7Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo7", 30, 30); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo7(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo7Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
