using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproductor1a : MonoBehaviour
{
    public Transform reproductorEnemgo1Gameobject; 
    // Start is called before the first frame update
    void Start()
    {
          InvokeRepeating("ReproducirEnemigo1", 2, 70); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void ReproducirEnemigo1(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorEnemgo1Gameobject,gameObject.transform.position,Quaternion.identity);

       
         
         


    }
   
}
