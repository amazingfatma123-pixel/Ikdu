using System;
using UnityEngine;

public class Menu_manager : MonoBehaviour
{
    [SerializeField]
    public GameObject videopanel;
    [SerializeField]
    public GameObject mathpanel;
    [SerializeField]
    public GameObject kebabpanel;

    public void changeWindow(String window)
    {
        videopanel.SetActive(window == "video");
        mathpanel.SetActive(window == "math");
        kebabpanel.SetActive(window == "kebab");
    }
}
