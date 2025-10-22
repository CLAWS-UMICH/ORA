using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Show screen1 at start, hide screen2
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    // Turns on screen 1 and hides screen 2
    public void ShowScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    // Turns on screen 2 and hides screen 1
    public void ShowScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}
