using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwinM : MonoBehaviour
{      
    public Image ganaste;
    public Text contador;
    public Button siguiente;
    public GameObject musica;
     
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
                    

            //
            contador.text = "Time 00:" + (int)Global.tiempo;
           

        }
        if(Global.tiempo<=0){
            Debug.Log("tirmp");
           
            ganaste.gameObject.SetActive(true);
            siguiente.gameObject.SetActive(true);  
            musica.gameObject.SetActive(false); 
            //reiniciar.gameObject.SetActive(true);
         }
        
    }
       
    
}
