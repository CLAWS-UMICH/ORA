using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }
    public void SwitchToPage1(){
        screen1.SetActive(true);
        screen2.SetActive(false);
    }
    public void SwitchToPage2(){
        screen1.SetActive(false);
        screen2.SetActive(true);
    }


}
