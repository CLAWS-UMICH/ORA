using MixedReality.Toolkit.UX;
using UnityEngine;

public class VitalsUpdate : MonoBehaviour
{
    private Subscription<VitalsEvent> vitalsUpdateEvent;
    private Subscription<VitalsEvent> fellowVitalsUpdateEvent;

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
        vitalsUpdateEvent = EventBus.Subscribe<VitalsEvent>(vitalsEventHandler);
        fellowVitalsUpdateEvent = EventBus.Subscribe<VitalsEvent>(fellowVitalsEventHandler);
    }

    // The function that gets called when the event is fired for EVA1
    private void vitalsEventHandler(VitalsEvent e)
    {
        // Update text
        eva1_heartRateText.GetComponent<TMPro.TextMeshProUGUI>().text = e.VitalsDetails.heart_rate.ToString("F0");

        // Update radial
        eva1_heartRateText.transform.Find("RingFull").GetComponent<SpriteRenderer>().material.SetFloat("_Arc1", (float)((1 - e.VitalsDetails.heart_rate / e.VitalsDetails.maxHeartRate) * 302));

        // Update progress bars for oxygen and battery
        int oxyTimeLeftSeconds = e.VitalsDetails.oxy_time_left;
        int oxyHours = oxyTimeLeftSeconds / 3600;
        int oxyMinutes = (oxyTimeLeftSeconds % 3600) / 60;
        eva1_oxygenTimeLeftText.transform.Find("Value").GetComponent<TextMeshPro>().text = $"{oxyHours} hr {oxyMinutes} m";
        eva1_oxySlider.GetComponent<Slider>().value = e.VitalsDetails.oxy_time_left;

        // Repeat for battery, suit temp, etc.
    }

    // The function that gets called when the event is fired for the fellow astronaut
    private void fellowVitalsEventHandler(VitalsEvent e)
    {
        // Update fellow astronaut's vitals UI
        eva2_heartRateText.GetComponent<TMPro.TextMeshProUGUI>().text = e.VitalsDetails.heart_rate.ToString("F0");
        // Similar updates for oxygen, suit temperature, battery, etc.
    }
}
