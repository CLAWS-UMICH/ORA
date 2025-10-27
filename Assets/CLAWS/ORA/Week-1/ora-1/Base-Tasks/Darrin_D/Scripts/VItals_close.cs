using UnityEngine;

public class VItals_close : MonoBehaviour
{

    [SerializeField] private GameObject screen1;


    public void OnScreen1()
        {
            screen1.SetActive(false);
        }
}
