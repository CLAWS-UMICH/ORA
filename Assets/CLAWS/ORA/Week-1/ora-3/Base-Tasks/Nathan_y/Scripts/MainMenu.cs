using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject screen1;
    [SerializeField] private GameObject screen2;
    [SerializeField] public Renderer targetRenderer;

    void Start()
    {
        screen1.SetActive(true);
    }

    void Update()
    {
        // Example: animate the arc opening
        float arcLength = Mathf.PingPong(Time.time * 60f, 360f);

        targetRenderer.material.SetFloat("_Angle", 90f);   // center of the arc
        targetRenderer.material.SetFloat("_Arc1", arcLength / 2f); // left side extent
        targetRenderer.material.SetFloat("_Arc2", arcLength / 2f); // right side extent
    }

    public void turnOnScreen1()
    {
        screen1.SetActive(true);
        screen2.SetActive(false);
        targetRenderer.material.SetInt("_Arc1", 50);
    }
    public void turnOnScreen2()
    {
        screen2.SetActive(true);
        screen1.SetActive(false);
        targetRenderer.material.SetInt("_Arc1", 0);
    }

}
