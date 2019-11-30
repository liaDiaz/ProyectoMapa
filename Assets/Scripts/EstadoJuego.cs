using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

[System.Serializable]

public class EstadoJuego : MonoBehaviour
{
    public string path = @"Assets/Guardar";
    public static EstadoJuego estadoJuego;
    public String rutaArchivo;
    void Awake(){
        rutaArchivo=Application.persistentDataPath+"/datos.dat";
        if(estadoJuego==null){
            estadoJuego=this;
             DontDestroyOnLoad(gameObject);
              Debug.Log("soyelprimero");
        }else if(estadoJuego!= this){
            Destroy(gameObject);
            Debug.Log("yaexistia");
            
        }

       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Guardar(){
         //IFormatter formatter = new BinaryFormatter();
        //Stream stream = new FileStream(path,
                                     //FileMode.Create,
                                     //FileAccess.Write,
                                     //FileShare.None);
       // formatter.Serialize(stream, t);
        //stream.Close();

    }
    void Cargar(){
         //IFormatter formatter = new BinaryFormatter();
        //Stream stream = new FileStream(path,
                                      //FileMode.Open,
                                      //FileAccess.Read,
                                      //FileShare.Read);
    }
}
