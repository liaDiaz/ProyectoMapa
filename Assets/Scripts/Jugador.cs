using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public float speed;
     public Text contador;
    public double tiempo=15;
   public Image    ganaste;
    public Image    perdiste;
  
 
   
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
        // input accede al cambio de los parametros 
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        //Time.deltaTime es para que no vaya tan rapido 
        gameObject.transform.Translate(new Vector2(x,y)*speed*Time.deltaTime);
        //si tiempo es mayor a cero
        // velo reducuiendo
        if (tiempo > 0)
        {
          
            //ScoreText.text = "Score:" + score;
            tiempo -= Time.deltaTime;
            //
            contador.text = "Time 00:" + (int)tiempo;
           

        }

        
    }
     void OnTriggerEnter2D(Collider2D otro) {
    // si mi mapa no tinen un colider no nesecita el if para que lo encuntre porque no choca con nada
         if(otro.gameObject.tag == "Piano") {
              slider.value -= 0.05f;
             //se destruira el piano
            Destroy(otro.gameObject);
         
        
         }
     }


    
     void Ganaste(){
         ganaste.gameObject.SetActive(true);

     }
     void Perdiste(){
         perdiste.gameObject.SetActive(true);

     }
     
  
}

