using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoginSceneManager : MonoBehaviour
{
    [SerializeField] GameObject splashScreen;
    [SerializeField] Transform loadingInner;

    // Start is called before the first frame update
    void Start()
    {
        HideSplash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HideSplash()
    {
        loadingInner.localScale += new Vector3(0.01f, 0, 0);
        if (loadingInner.localScale.x > 0.999f)
        {
            splashScreen.SetActive(false);
        }
        if (splashScreen.activeInHierarchy)
        {
            Invoke(nameof(HideSplash), 0.05f);
        }
    }

    public void LoadMainMenu()
    {
        GameManager.gameMngr.LoadScene(1);
    }
}
