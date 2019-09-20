using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlador : MonoBehaviour
{
    public Text contador;
    public float tiempo=15f;
    // Start is called before the first frame update
    //inicializa todo
    void Start()
    {
         contador.text=""+tiempo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
