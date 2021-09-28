using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript1 : MonoBehaviour
{
    public void loadlevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
