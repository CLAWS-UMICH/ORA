using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private GameObject screen1;

    [SerializeField] private GameObject screen2;

    void Start()
    {

    }

    public void SwitchToScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    public void SwitchToScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
}
