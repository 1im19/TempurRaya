using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscrpt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Story()
    {
        SceneManager.LoadScene("Cutscene 1");
    }

    public void EndlessWave()
    {
        SceneManager.LoadScene("Endless Wave Stats Display");
    }

    

    public void Quit ()
    {
        Application.Quit();
    }

}
