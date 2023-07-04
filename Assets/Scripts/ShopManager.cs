using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public List<GameObject> ButtonOpener  = new List<GameObject>();
    public List<GameObject> ButtonOpener2 = new List<GameObject>();
    public List<GameObject> ButtonOpener3 = new List<GameObject>();
    public List<GameObject> ButtonOpener4 = new List<GameObject>();
    public List<GameObject> ButtonOpener5 = new List<GameObject>();
    public bool isShopOpen = false, isShopOpen2 = false, isShopOpen3 = false, isShopOpen4 = false, isShopOpen5 = false;
    public void OpenShop()
    {
        if (isShopOpen)
        {
            isShopOpen = false;
            foreach (GameObject item in ButtonOpener)
            {
                item.SetActive(false);
            }
        }
        else
        {
           StartCoroutine(ShopOpener(ButtonOpener));
            isShopOpen = true;
        }
        
    }
    public void OpenShop2()
    {
        if (isShopOpen2)
        {
            isShopOpen2 = false;
            foreach (GameObject item in ButtonOpener2)
            {
                item.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(ShopOpener(ButtonOpener2));
            isShopOpen2 = true;
        }
    }
    public void OpenShop3()
    {
        if (isShopOpen3)
        {
            isShopOpen3 = false;
            foreach (GameObject item in ButtonOpener3)
            {
                item.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(ShopOpener(ButtonOpener3));
            isShopOpen3 = true;
        }
    }
    public void OpenShop4()
    {
        if (isShopOpen4)
        {
            isShopOpen4 = false;
            foreach (GameObject item in ButtonOpener4)
            {
                item.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(ShopOpener(ButtonOpener4));
            isShopOpen4 = true;
        }
    }
    public void OpenShop5()
    {
        if (isShopOpen5)
        {
            isShopOpen5 = false;
            foreach (GameObject item in ButtonOpener5)
            {
                item.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(ShopOpener(ButtonOpener5));
            isShopOpen5 = true;
        }
    }
    IEnumerator ShopOpener(List<GameObject> ButtonToOpen)
    {
        foreach (GameObject item in ButtonToOpen)
        {
            yield return new WaitForSeconds(0.1f);
            item.SetActive(true);
        }
    }
}
