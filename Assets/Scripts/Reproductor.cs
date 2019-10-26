using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{

    // se pone de tipo transform pues asi le qudes que es para modificar 
    //la rotacon y la posicion de un gameobject
    public Transform limiteIzquieda;
    public Transform limiteDerecha;
    public Transform limiteIzquiedaitem;
    public Transform limiteDerechaitem;
    public Transform reproductorGameobject;
    public Transform reproductorGameobjectItem;
    public Transform limiteIzquiedConejo;
    public Transform limiteDerechaConejo;
    public Transform reproductorGameobjectConejo;


    // Start is called before the first frame update
    void Start()
    {
        // nuemoro de veces que se retira y el tiempo
        InvokeRepeating("Reproducir", 2, 1); 
        InvokeRepeating("Reproduciritem", 2, 1); 
        InvokeRepeating("Reproducirconejo", 2, 1); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // haz un metodo para que vea los limites 
    void Reproducir(){
        // sirve para instanciar crear e iniciar varibales
        // este Instantiate nos hace hacer muchas copias //cambiar la pocision
        //Este Quaternion corresponde a "sin rotación"
         Instantiate(reproductorGameobject,gameObject.transform.position,Quaternion.identity);

         //gameObject.transform.position es como si pusuieras esto  nuevo Vector3 (i * 2.0F, 0, 0
         Vector3 nuevaPosition=gameObject.transform.position;
         // para darle posisiones random  del rango  de los limites en la posicion en x
         nuevaPosition.x=Random.Range(limiteIzquieda.position.x,limiteDerecha.position.x);
         //
         gameObject.transform.position=nuevaPosition;


         
         


    }
    void Reproduciritem(){
        Instantiate(reproductorGameobjectItem,gameObject.transform.position,Quaternion.identity);

         //gameObject.transform.position es como si pusuieras esto  nuevo Vector3 (i * 2.0F, 0, 0
         Vector3 nuevaPositionitem=gameObject.transform.position;
         // para darle posisiones random  del rango  de los limites en la posicion en x
         nuevaPositionitem.x=Random.Range(limiteIzquiedaitem.position.x,limiteDerechaitem.position.x);
         //
         gameObject.transform.position=nuevaPositionitem;
    }
     void Reproducirconejo(){
        Instantiate(reproductorGameobjectConejo,gameObject.transform.position,Quaternion.identity);

         //gameObject.transform.position es como si pusuieras esto  nuevo Vector3 (i * 2.0F, 0, 0
         Vector3 nuevaPositionconejo=gameObject.transform.position;
         // para darle posisiones random  del rango  de los limites en la posicion en x
         nuevaPositionconejo.x=Random.Range(limiteIzquiedConejo.position.x,limiteDerechaConejo.position.x);
         //
         gameObject.transform.position=nuevaPositionconejo;
    }
}
