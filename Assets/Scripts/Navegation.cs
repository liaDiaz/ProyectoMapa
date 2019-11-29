using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Navegation : MonoBehaviour
{
    int index=0;
    public int totalLevels=2;
    public float yoff=2.5f;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        z=transform.position.z;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            if(index<totalLevels-1){
                index++;
                // esto es solo para bvector 3

                Vector3 position=transform.position;
                position.y-=yoff;
                transform.position=position;
            }
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            if(index>0){
                index--;
                Vector3 position=transform.position;
                position.y+=yoff;
                transform.position=position;
            }
        }
        if(Input.GetKeyDown(KeyCode.Return)){
             if(index==0){
            SceneManager.LoadScene("Instruccionesnivel1");
             }
        
        }
       
    }
}

