using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public float speed;
   
     public Text contador;
  
   public Image    ganaste;
    public Image    perdiste;
      
    public Button reiniciar;
     public Button siguiente;
 
   
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
           
             contador.text = "Time 00:" ;
             
    }

    // Update is called once per frame
    // aqui se ponen los compotamientos del juego o jugador 

    void Update()
    {


    float xs = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
     transform.Translate(xs, 0f, 0f);
     // initially, the temporary vector should equal the player's position
     Vector3 clampedPosition = transform.position;
     // Now we can manipulte it to clamp the y element
     clampedPosition.x = Mathf.Clamp(clampedPosition.x, -9.1f, 9.1f);
     // re-assigning the transform's position will clamp it
     transform.position = clampedPosition;
        // input accede al cambio de los parametros 
            
        
        //si tiempo es mayor a cero
        // velo reducuiendo
        if (Global.tiempo > 0)
        {
         
          
           Global.tiempo -= Time.deltaTime;
            //
            contador.text = "Time 00:" + (int)Global.tiempo;
           

        }
         Perdiste();
        // Ganaste();
        
        
    }
     void OnTriggerEnter2D(Collider2D otro) {
    // si mi mapa no tinen un colider no nesecita el if para que lo encuntre porque no choca con nada
         if(otro.gameObject.tag == "Piano") {
              slider.value -= 0.9f;
             //se destruira el piano
            Destroy(otro.gameObject);
         
        
         }
          if(otro.gameObject.tag == "Itemeat") {
              slider.value += 0.09f;
             //se destruira el piano
            Destroy(otro.gameObject);
         
        
         }

          if(otro.gameObject.tag == "conejo") {
              speed+= 0.5f;
             //se destruira el piano
            Destroy(otro.gameObject);
         
        
         }
        

     }
    

    
     
    public  void Perdiste(){
         if(slider.value==0){
           
            perdiste.gameObject.SetActive(true);
            reiniciar.gameObject.SetActive(true);
        }else if(Global.tiempo<=0 && slider.value!=0){
            ganaste.gameObject.SetActive(true);
             siguiente.gameObject.SetActive(true);
        }
         

     }

     public void Reiniciar(){
          perdiste.gameObject.SetActive(false);
          Global.tiempo=60;
          reiniciar.gameObject.SetActive(false);
            siguiente.gameObject.SetActive(false);
           InvokeRepeating("Reproducir", 1, 1); 
           InvokeRepeating("Reproduciritem", 2, 1); 
        
        slider.value =1;
          



     }
     
  
}

