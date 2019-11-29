using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwinM : MonoBehaviour
{      
    public Image ganaste;
    public Text contador;
    public Button siguiente;
     
    // Start is called before the first frame update
    void Start()
    {
        contador.text = "Time 00:" ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.tiempo > 0){
         
          
           Global.tiempo -= Time.deltaTime;
            siguiente.gameObject.SetActive(true);           

            //
            contador.text = "Time 00:" + (int)Global.tiempo;
           

        }
    }
    public  void Perdiste(){
         if(Global.tiempo==0){
           
            ganaste.gameObject.SetActive(true);
            //reiniciar.gameObject.SetActive(true);
         }
    }
}
