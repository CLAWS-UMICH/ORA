
using UnityEngine;

public class MainMenu1 : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;

    // This function must be public
    public void ToggleScreens(int screenIndex)
    {
        screen1.SetActive(screenIndex == 0);
        screen2.SetActive(screenIndex == 1);
    }
}




