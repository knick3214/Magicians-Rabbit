using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour
{

    [SerializeField] GameObject[] friendsInsidePanels;
    [SerializeField] Image[] friendsInsideBtns;

    [Header("Shop Objects")]
    [SerializeField] GameObject[] shopinsidePanels;
    [SerializeField] Image[] shopInsideBtns;
    [SerializeField] GameObject[] bigPkgs;
    [SerializeField] Sprite highlightedBtnSprite, normalBtnSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLoginScene()
    {
        GameManager.gameMngr.LoadScene(0);
    }

    public void LoadGameScene()
    {
        GameManager.gameMngr.LoadScene(2);
    }

    public void OpenFriendsInsidePanel(GameObject panelToOpen)
    {
        panelToOpen.SetActive(true);
        foreach (var item in friendsInsidePanels)
        {
            if (panelToOpen != item) item.SetActive(false);
        }
    }

    public void SetFriendsInsidePanelBtnSprite(Image img)
    {
        img.sprite = highlightedBtnSprite;
        foreach (var item in friendsInsideBtns)
        {
            if (img != item) item.sprite = normalBtnSprite;
        }
    }

    public void OpenShopInsidePanel(GameObject panelToOpen)
    {
        panelToOpen.SetActive(true);
        foreach (var item in shopinsidePanels)
        {
            if (panelToOpen != item) item.SetActive(false);
        }
    }

    public void SetShopInsidePanelBtnSprite(Image img)
    {
        img.sprite = highlightedBtnSprite;
        foreach (var item in shopInsideBtns)
        {
            if (img != item) item.sprite = normalBtnSprite;
        }
    }

    public void OpenBigPackage(GameObject pkg)
    {
        pkg.SetActive(true);
        foreach (var item in bigPkgs)
        {
            if (pkg != item) item.SetActive(false);
        }
    }
}
