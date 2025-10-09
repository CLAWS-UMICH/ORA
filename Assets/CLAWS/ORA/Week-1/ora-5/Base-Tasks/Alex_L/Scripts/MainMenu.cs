using UnityEngine;

public class MainMenu : MonoBehaviour{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    void Start(){
        //screen1.SetActive(true);
    }

    public void showScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
    }

    public void showScreen2()
    {
        screen2.SetActive(true);
        screen1.SetActive(false);
    }
    
    
}
