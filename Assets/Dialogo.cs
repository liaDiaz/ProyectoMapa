using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// esto es para que mis variables se puedan ver en el ispector 
[System.Serializable]

public class Dialogo 
{
    // Start is called before the first frame update
    public string name;
    [TextArea(3,10)]
    public string[] listadeEnunciados;
}
