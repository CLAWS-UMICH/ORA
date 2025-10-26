using System.Collections.Generic;

// Last Updated:
//    Molly M. -- 9/30/2025


// Example Event Type:
public class Event 
{
    public string message { get; private set; }

    public Event(string msg)
    {
        message = msg;
    }
}

// Add event types here as needed...
// TODO:
// - Add a vitals update event type for EV1
// - Add a vitals update event type for EV2
public class EV1VitalsUpdateEvent
{
    public VitalsDetails vitalsDetails { get; private set; }

    public EV1VitalsUpdateEvent(VitalsDetails vd)
    {
        vitalsDetails = vd;
    }
}

public class EV2VitalsUpdateEvent
{
    public VitalsDetails vitalsDetails { get; private set; }

    public EV2VitalsUpdateEvent(VitalsDetails vd)
    {
        vitalsDetails = vd;
    }
}
