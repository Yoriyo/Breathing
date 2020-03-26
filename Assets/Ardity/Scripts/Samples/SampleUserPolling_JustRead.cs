/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections;

/**
 * Sample for reading using polling by yourself. In case you are fond of that.
 */
public class SampleUserPolling_JustRead : MonoBehaviour
{
    public SerialController serialController;
    public GameObject Player;
    public ThirdPersonCharacterControl component;
    // Initialization
    public float x;
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
        // Player = GameObject.Find ("Player");
        component = GetComponent<ThirdPersonCharacterControl>();
    }

    // Executed each frame
    void Update()
    {
        string message = serialController.ReadSerialMessage();
        float.TryParse(message, out x);
        // x = x*2 + 3;
        if (message == null)
            return;

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
            Debug.Log("Connection established");
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
            Debug.Log("Connection attempt failed or disconnection detected");
        else
            Debug.Log(x);
            Debug.Log(component.Speed = x);
            

    }
}
