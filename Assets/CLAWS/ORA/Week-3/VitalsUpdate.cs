using MixedReality.Toolkit.UX;
using TMPro;
using UnityEngine;

public class VitalsUpdate : MonoBehaviour
{
    private Subscription<EV1VitalsUpdateEvent> vitalsUpdateEvent;
    private Subscription<EV2VitalsUpdateEvent> fellowVitalsUpdateEvent;

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
    // suit helmet pressure
    [SerializeField] private GameObject eva1_suitPressureTotalText;
    [SerializeField] private GameObject eva1_helmetPressureCO2Text;
    [SerializeField] private GameObject eva1_suitPressureO2Text;
    [SerializeField] private GameObject eva1_suitPressureCO2Text;
    [SerializeField] private GameObject eva1_suitPressureOtherText;
    

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

    [SerializeField] private GameObject eva2_oxySlider;
    // suit helmet pressure
    [SerializeField] private GameObject eva2_suitPressureTotalText;
    [SerializeField] private GameObject eva2_helmetPressureCO2Text;
    [SerializeField] private GameObject eva2_suitPressureO2Text;
    [SerializeField] private GameObject eva2_suitPressureCO2Text;
    [SerializeField] private GameObject eva2_suitPressureOtherText;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vitalsUpdateEvent = EventBus.Subscribe <EV1VitalsUpdateEvent> (vitalsEventHandler);
        fellowVitalsUpdateEvent = EventBus.Subscribe <EV2VitalsUpdateEvent> (fellowVitalsEventHandler);
    }


    // the function that gets called when the event is fired
    private void vitalsEventHandler(EV1VitalsUpdateEvent e)
    {
        // suit helmet pressure text
        eva1_suitPressureTotalText.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_total.ToString("F1");
        eva1_helmetPressureCO2Text.GetComponent<TextMeshPro>().text = e.vitalsDetails.helmet_pressure_co2.ToString("F1");
        eva1_suitPressureO2Text.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_oxy.ToString("F1");
        eva1_suitPressureCO2Text.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_co2.ToString("F1");
        eva1_suitPressureOtherText.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_other.ToString("F1");
        
        // heart rate text
        eva1_heartRateText.GetComponent<TextMeshPro>().text = e.vitalsDetails.heart_rate.ToString("F0");

        // radial
        // eva1_heartRateText.transform.Find("RingFull").GetComponent<SpriteRenderer>().material.SetFloat("_Arc1", (float)((1 - e.vitalsDetails.heart_rate / 200) * 302));

        // progress bars
        // **Youll have to edit the slider in the inspector to set the max value**
        // int oxyTimeLeftSeconds = e.vitalsDetails.oxy_time_left;
        // int oxyHours = oxyTimeLeftSeconds / 3600;
        // int oxyMinutes = oxyTimeLeftSeconds % 3600 / 60;
        // Debug.Log(oxyTimeLeftSeconds);
        // eva1_oxygenTimeLeftText.transform.Find("Value").GetComponent<TextMeshPro>().text = $"{oxyHours} hr {oxyMinutes} m";
        // eva1_oxySlider.GetComponent<Slider>().Value = e.vitalsDetails.oxy_time_left;
        // repeat for battery
    }


    private void fellowVitalsEventHandler(EV2VitalsUpdateEvent e)
    {
        // repeat for fellow astronaut
        // ...
        // suit helmet pressure text
        eva2_suitPressureTotalText.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_total.ToString("F1");
        eva2_helmetPressureCO2Text.GetComponent<TextMeshPro>().text = e.vitalsDetails.helmet_pressure_co2.ToString("F1");
        eva2_suitPressureO2Text.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_oxy.ToString("F1");
        eva2_suitPressureCO2Text.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_co2.ToString("F1");
        eva2_suitPressureOtherText.GetComponent<TextMeshPro>().text = e.vitalsDetails.suit_pressure_other.ToString("F1");
        

        // text
        eva2_heartRateText.GetComponent<TextMeshPro>().text = e.vitalsDetails.heart_rate.ToString("F0");

        // radial
        // Play around with the arc and angle values for the ringFull object
        // eva2_heartRateText.transform.Find("RingFull").GetComponent<SpriteRenderer>().material.SetFloat("_Arc1", (float)((1 - e.vitalsDetails.heart_rate / 200) * 302));

        // progress bars
        // **Youll have to edit the slider in the inspector to set the max value**
        // int oxyTimeLeftSeconds = e.vitalsDetails.oxy_time_left;
        // int oxyHours = oxyTimeLeftSeconds / 3600;
        // int oxyMinutes = oxyTimeLeftSeconds % 3600 / 60;
        // //Debug.Log(oxyTimeLeftSeconds);
        // eva2_oxygenTimeLeftText.transform.Find("Value").GetComponent<TextMeshPro>().text = $"{oxyHours} hr {oxyMinutes} m";
        // eva2_oxySlider.GetComponent<Slider>().Value = e.vitalsDetails.oxy_time_left;
        // repeat for battery
    }

}
