using MixedReality.Toolkit.UX;
using UnityEngine;

public class VitalsUpdate : MonoBehaviour
{
    private Subscription<??> vitalsUpdateEvent;
    private Subscription<??> fellowVitalsUpdateEvent;

    [SerializeField] private GameObject eva1Screen; // Handle UI for EV1
    [SerializeField] private GameObject eva2Screen; // Handle UI for fellow astronaut

    // EVA1 VITALS
    [SerializeField] private GameObject eva1_heartRateText;
    [SerializeField] private GameObject eva1_oxygenTimeLeftText;
    [SerializeField] private GameObject eva1_oxySlider;
    [SerializeField] private GameObject eva1_suitTempText;
    [SerializeField] private GameObject eva1_batteryTimeLeftText;
    [SerializeField] private GameObject eva1_batterySlider;
    [SerializeField] private GameObject eva1_oxyPrimaryText;
    [SerializeField] private GameObject eva1_oxySecondaryText;

    // EVA2 VITALS
    [SerializeField] private GameObject eva2_heartRateText;
    private float eva2_oxygenTimeLeft;
    [SerializeField] private GameObject eva2_oxygenTimeLeftText;
    private float eva2_SuitTemp;
    [SerializeField] private GameObject eva2_suitTempText;
    private float eva2_batteryTimeLeft;
    [SerializeField] private GameObject eva2_batteryTimeLeftText;
    private float eva2_oxyPrimary;
    [SerializeField] private GameObject eva2_oxyPrimaryText;
    private float eva2_oxySecondary;
    [SerializeField] private GameObject eva2_oxySecondaryText;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vitalsUpdateEvent = EventBus.Subscribe <??> (vitalsEventHandler);
        fellowVitalsUpdateEvent = EventBus.Subscribe <??> (fellowVitalsEventHandler);
    }


    // the function that gets called when the event is fired
    private void vitalsEventHandler(?? e)
    {
        // text
        eva1_heartRateText.GetComponent<TMPro.TextMeshProUGUI>().text = e.VitalsDetails.heart_rate.ToString("F0");

        // radial
        // Play around with the arc and angle values for the ringFull object
        eva1_heartRateText.transform.Find("RingFull").GetComponent<SpriteRenderer>().material.SetFloat("_Arc1", (float)((1 - e.VitalsDetails / < max_range >) * 302));

        // progress bars
        // **Youll have to edit the slider in the inspector to set the max value**
        int oxyTimeLeftSeconds = e.vitalsDetails.oxy_time_left;
        int oxyHours = oxyTimeLeftSeconds / 3600;
        int oxyMinutes = oxyTimeLeftSeconds % 3600 / 60;
        //Debug.Log(oxyTimeLeftSeconds);
        eva1_oxygenTimeLeftText.transform.Find("Value").GetComponent<TextMeshPro>().text = $"{oxyHours} hr {oxyMinutes} m";
        eva1_oxySlider.GetComponent<Slider>().Value = e.vitalsDetails.oxy_time_left;
        // repeat for battery
    }


    private void fellowVitalsEventHandler(?? e)
    {
        // repeat for fellow astronaut
        // ...
    }

}
