using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor3 : MonoBehaviour
{
    public Transform reproductorEnemgo3Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("ReproducirEnemigo3", 15, 35); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

       void ReproducirEnemigo3(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo3Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
}
