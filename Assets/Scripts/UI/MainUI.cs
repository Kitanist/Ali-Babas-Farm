using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public GameObject start, Settings,  SettingsMenu, Shop, ShopMenu,feature,SocialMedia;
    public int index;
    private void Start()
    {
        ShutDownEverything();
        OpenMainMenu();
    }
    public void ShutDownEverything()
    {
        start.SetActive(false);
        Settings.SetActive(false);
        SocialMedia.SetActive(false);
        feature.SetActive(false);
        SettingsMenu.SetActive(false);
        Shop.SetActive(false);
        ShopMenu.SetActive(false);
    }
    public void OpenMainMenu()
    {
        SocialMedia.SetActive(true);
        feature.SetActive(true);
        Shop.SetActive(true);
        start.SetActive(true);
        Settings.SetActive(true);
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(index);

    }
    public void OpenSettings()
    {
        ShutDownEverything();
        SettingsMenu.SetActive(true);
    }
    public void CloseSettings()
    {
        ShutDownEverything();
        OpenMainMenu();

    }
    public void OpenShop()
    {
        ShutDownEverything();
        ShopMenu.SetActive(true);
    }
    public void CloseShop()
    {
        ShutDownEverything();
        OpenMainMenu();
    }
   
}
