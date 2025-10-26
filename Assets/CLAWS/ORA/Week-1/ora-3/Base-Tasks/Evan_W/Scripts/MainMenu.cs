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
        AstronautInstance.User.id = 1;
        AstronautInstance.User.fellowAstronaut.id = 2;
    }

    public void EnableScreenOne()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
        AstronautInstance.User.id = 1;
        AstronautInstance.User.fellowAstronaut.id = 2;
    }

    public void EnableScreenTwo()
    {
        screen2.SetActive(true);
        screen1.SetActive(false);
        AstronautInstance.User.id = 2;
        AstronautInstance.User.fellowAstronaut.id = 1;
    }

}
