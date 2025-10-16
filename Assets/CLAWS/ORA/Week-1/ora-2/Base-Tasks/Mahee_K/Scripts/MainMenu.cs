using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    
    [SerializeField] private GameObject screen2;

    void Start()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    public void UpdateScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    public void UpdateScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}