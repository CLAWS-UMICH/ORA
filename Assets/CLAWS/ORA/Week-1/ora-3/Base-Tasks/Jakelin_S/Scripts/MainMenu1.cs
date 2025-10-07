using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject screen1;
    public GameObject screen2;

    // Called automatically when the scene starts
    void Start()
    {
        screen1.SetActive(true);   // Show Screen 1
        screen2.SetActive(false);  // Hide Screen 2
    }

    // Function to show Screen 1
    public void ShowScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    // Function to show Screen 2
    public void ShowScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}



