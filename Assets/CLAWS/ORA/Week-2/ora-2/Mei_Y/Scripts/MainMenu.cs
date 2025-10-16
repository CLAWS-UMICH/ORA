using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;
    [SerializeField] private GameObject screen3;

    void Start()
    {
        if (screen2 != null) screen2.SetActive(false);
        if (screen3 != null) screen3.SetActive(false);
    }
    public void StartScreen1()
    {
        SetPair(screen2On: true, screen3On: false);
    }
    public void StartScreen2()
    {
        SetPair(screen2On: false, screen3On: true);
    }

    private void SetPair(bool screen2On, bool screen3On)
    {
        if (screen2 != null) screen2.SetActive(screen2On);
        if (screen3 != null) screen3.SetActive(screen3On);
    }
}

