using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    public static GameManager gameMngr;

    // Start is called before the first frame update
    void Start()
    {
        if (gameMngr == null) gameMngr = this;
        else if (gameMngr != this) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        
    }

    

    public void LoadScene(int sceneCount)
    {
        SceneManager.LoadScene(sceneCount);
    }
}
