using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo_Mangment : MonoBehaviour
{
    public Dialogo dialogo;
    //listado de objecto 
    Queue<string> enunciados;
    public GameObject dialogoPanel;
    public TextMeshProUGUI displayText;

    string activarEnunciado;
    public float typingSpeed;


   
    // Start is called before the first frame update
    void Start()
    {
        enunciados=new Queue<string>();
        
    }
    void StartDialogo(){
        enunciados.Clear();
        foreach(string enunciado in dialogo.listadeEnunciados)
        {
            enunciados.Enqueue(enunciado);
        }
        DisplayNextSentences();
    }
    void  DisplayNextSentences()
    {
        if(enunciados.Count<=0)
        {
            displayText.text=activarEnunciado;
            return;

        }
        activarEnunciado=enunciados.Dequeue();
        Debug.Log(activarEnunciado);
    }
    
    // Update is called once per frame
   private void OnTriggerEnter2D(Collider2D other)
   {
        if(other.gameObject.tag == "Player")
         {
           StartDialogo();
       }

   }
}
