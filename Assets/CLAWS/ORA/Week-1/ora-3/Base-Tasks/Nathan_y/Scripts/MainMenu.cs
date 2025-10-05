using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    void Start()
    {
        screen1.SetActive(true);
    }

    public void turnOnScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }
    public void turnOnScreen2()
    {
        screen2.SetActive(true);
        screen1.SetActive(false);
    }

}
