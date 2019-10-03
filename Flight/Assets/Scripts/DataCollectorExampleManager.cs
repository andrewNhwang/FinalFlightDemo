/*using UnityEngine;
using Vhil.DataCollector;


public class DataCollectorExampleManager : MonoBehaviour
{
    public Rigidbody rigidbody;

    private DataWriter<TrackingData> trackingDataWriter;

    void Start()
    {
        trackingDataWriter = DataWriter<TrackingData>.Create("Data/tracking_data.csv");
    }

    // Update is called once per frame
    void Update()
    {
        trackingDataWriter.Write(rigidbody);
    }

    void OnApplicationQuit()
    {
        trackingDataWriter.Dispose();
    }
}
*/