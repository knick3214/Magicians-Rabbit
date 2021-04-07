using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSceneManager : MonoBehaviour
{

    [SerializeField] GameObject invitePanel, requestsPanel, connectionsPanel;
    [SerializeField] Image inviteBtn, requestsBtn, connectionsBtn;
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

    public void OpenInvitePanel()
    {
        connectionsPanel.SetActive(false);
        requestsPanel.SetActive(false);
        requestsBtn.sprite = normalBtnSprite;
        connectionsBtn.sprite = normalBtnSprite;
        inviteBtn.sprite = highlightedBtnSprite;
        invitePanel.SetActive(true);
    }

    public void OpenRequestsPanel()
    {
        connectionsPanel.SetActive(false);
        invitePanel.SetActive(false);
        connectionsBtn.sprite = normalBtnSprite;
        inviteBtn.sprite = normalBtnSprite;
        requestsBtn.sprite = highlightedBtnSprite;
        requestsPanel.SetActive(true);
    }

    public void OpenConnectionsPanel()
    {
        requestsPanel.SetActive(false);
        invitePanel.SetActive(false);
        requestsBtn.sprite = normalBtnSprite;
        inviteBtn.sprite = normalBtnSprite;
        connectionsBtn.sprite = highlightedBtnSprite;
        connectionsPanel.SetActive(true);
    }
}
