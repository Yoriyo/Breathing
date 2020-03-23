/**
 * Ardity (Serial Communication for Arduino + Unity)
 * Author: Daniel Wilches <dwilches@gmail.com>
 *
 * This work is released under the Creative Commons Attributions license.
 * https://creativecommons.org/licenses/by/2.0/
 */

using UnityEngine;
using System.Collections;
using System.Globalization;


/**
 * Sample for reading using polling by yourself. In case you are fond of that.
 */
// public class SampleUserPolling_JustRead : MonoBehaviour
// {
//     public SerialController serialController;
//     // Initialization
//     void Start()
//     {
//         serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
// 	}

    

//     void Update()
//     {
//         string message = serialController.ReadSerialMessage();
//         public float x;
//         float.TryParse(message, out x);
//         // float message = (float) Convert.ToDouble(".");
//         // double y = (double) double.Parse("message");
//   		//var newScale = new Vector3 (x, 0.2f, 1f);
// 		// var speed = 2.0f;
// 		float y = x + 1;
// 		 if (message == null)
// 		 return;

//         // Check if the message is plain data or a connect/disconnect event.
//         if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
//             {
//             Debug.Log("Connection established");
//             }

//         else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
//             Debug.Log("Connection attempt failed or disconnection detected");
//         else
//             Debug.Log(message);
//             	transform.localScale = new Vector3 (y, y, y);
//             // transform.localScale = Vector3.Lerp (transform.localScale, newScale, speed * Time.deltaTime);
            
//     }

// }

public class SampleUserPolling_JustRead : MonoBehaviour
{
    public SerialController serialController;

    // Initialization
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
	}

    // Executed each frame
    void Update()
    {
        string message = serialController.ReadSerialMessage();
        public float x;
        float.TryParse(message, out x)
        if (message == null)
            return;

        // Check if the message is plain data or a connect/disconnect event.
        if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_CONNECTED))
            Debug.Log("Connection established");
        else if (ReferenceEquals(message, SerialController.SERIAL_DEVICE_DISCONNECTED))
            Debug.Log("Connection attempt failed or disconnection detected");
        else
            Debug.Log(message);
    }
}