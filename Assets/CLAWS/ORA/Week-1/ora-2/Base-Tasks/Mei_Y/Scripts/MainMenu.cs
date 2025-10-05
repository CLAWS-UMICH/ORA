using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    void Start()
    {
        screen1.SetActive(true);
    }
    public void StartScreen1()
    {
        screen1.SetActive(true);
    }
    public void StartScreen2()
    {
        screen2.SetActive(true);
    }
}

