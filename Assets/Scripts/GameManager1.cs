using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager1 : MonoBehaviour
{
    public GameObject Enemigo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Debug.Log("click");
            //Destroy(gameObject.CompareTag("enemigo"));
            //Enemigo.SetActive(false);
           
        }
    }

    
}
