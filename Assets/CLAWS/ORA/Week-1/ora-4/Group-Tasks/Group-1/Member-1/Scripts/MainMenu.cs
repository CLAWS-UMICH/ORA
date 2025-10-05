using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    void Start()
    {
        TurnOnScreen1();
    }

    public void TurnOnScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    public void TurnOnScreen2()
    {
        screen2.SetActive(true);
        screen1.SetActive(false);
    }
}