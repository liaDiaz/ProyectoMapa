using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton: MonoBehaviour
{

    public int num_Scene;

    public void LoadGame(int num_Scene)
    {
        SceneManager.LoadScene(num_Scene);
    }
}

