using UnityEngine;

public class MainMenu1 : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
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
