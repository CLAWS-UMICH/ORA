using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private GameObject screen1;

    [SerializeField] private GameObject screen2;

    [SerializeField] private GameObject vitals;

    bool vitalsState = false;
    int screenState = 0;

    void Start()
    {
        AstronautInstance.User = new Astronaut();
        AstronautInstance.User.TSSurl = "http://127.0.0.1:14141/";  // Your server IP
        AstronautInstance.User.id = 1;  // EVA1 or EVA2
        screen1.SetActive(true);
        screen2.SetActive(false);
        vitals.SetActive(false);
    }

    public void SwitchToScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
        closeVitals();
        screenState = 0;
    }

    public void SwitchToScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
        closeVitals();
        screenState = 1;
    }

    public void toggleVitals()
    {
        if (vitalsState)
        {
            if (screenState == 0)
            {
                screen1.SetActive(true);
                screen2.SetActive(false);
            }
            else if (screenState == 1)
            {
                screen1.SetActive(false);
                screen2.SetActive(true);
            }
            closeVitals();
        }
        else
        {
            screen1.SetActive(false);
            screen2.SetActive(false);
            vitals.SetActive(true);
            vitalsState = true;
        }
    }
    
    public void closeVitals()
    {
        vitals.SetActive(false);
        vitalsState = false;
    }
}
