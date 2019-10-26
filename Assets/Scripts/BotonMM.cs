using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonMM : MonoBehaviour
{
    public string Escena;
    public Color[] colores;
    public Image BotonImage;
    public bool Seleccionado = false;   
    
     // Start is called before the first frame update
    void Start()
    {
       BotonImage=GetComponent<Image>();
       BotonImage.color=colores[0]; 
        BotonImage.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Seleccionado)
        {
            BotonImage.color=colores[1];
            
       }
       else
       {
           BotonImage.color=colores[0];
       }

       if(Input.GetKeyDown(KeyCode.KeypadEnter)&& Seleccionado)
       {
        SceneManager.LoadScene(Escena, LoadSceneMode.Single);
       }
    }
}
