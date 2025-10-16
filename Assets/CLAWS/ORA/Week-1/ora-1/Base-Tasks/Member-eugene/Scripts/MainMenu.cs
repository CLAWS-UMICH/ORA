using UnityEngine;

public class MainMenu : MonoBehavior
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;
    void Start()
    {
        screen1.SetActive(true);
    }
    public void SetScreen1()
    {
        screen2.SetActive(false);
        screen1.SetActive(true);
    }
    public void SetScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}