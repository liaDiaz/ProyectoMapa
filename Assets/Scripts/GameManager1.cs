using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
  
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0)) {
            if(Physics.Raycast(ray,out hit,Mathf.Infinity)){
                if(hit.rigidbody.gameObject.GetInstanceID() == gameObject.GetInstanceID()){
                     Debug.Log("click");
                    gameObject.SetActive(false);
                     //Destroy(gameObject);
                }
            }
        }
           
            //Destroy(gameObject.CompareTag("enemigo"));
            //Enemigo.SetActive(false);
           
    }
        

  
   

    
}

