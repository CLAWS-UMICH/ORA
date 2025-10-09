using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;

    private void Start()
    {
        ShowScreen1(); // initializes correctly
    }

    public void ShowScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);

        // reset scale if needed
        screen1.transform.localScale = Vector3.one;
    }

    public void ShowScreen2()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);

        // reset scale if needed
        screen2.transform.localScale = Vector3.one;
    }
}
