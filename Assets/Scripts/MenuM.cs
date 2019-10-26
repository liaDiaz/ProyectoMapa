using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuM : MonoBehaviour
{
    public BotonMM[] botones;
    public int Posicion=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            botones[Posicion].Seleccionado=true;
            return;
        }
        if(Posicion<0){
            Posicion=botones.Length-1;
            botones[Posicion].Seleccionado=true;
            return;
        }
        if(Posicion>botones.Length-1){
            Posicion=0;
            botones[Posicion].Seleccionado=true;
            return;
        }
        botones[Posicion].Seleccionado=true;
    }
}
