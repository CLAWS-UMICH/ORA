using UnityEngine;

public class Main_Menu : MonoBehaviour
{

    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screen2.SetActive(false);
        screen1.SetActive(false);
    }

    public void OnScreen1()
    {
        screen2.SetActive(false);
        screen1.SetActive(true);
    }

    public void OnScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }
    
}
