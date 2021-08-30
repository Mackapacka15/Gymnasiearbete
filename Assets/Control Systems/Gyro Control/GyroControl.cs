using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{

    Gyroscope gyroInput;
    public GUIStyle style;

    // Start is called before the first frame update
    void Start()
    {
        gyroInput = Input.gyro;
        gyroInput.enabled = true;
    }

    void OnGUI()
    {
        //Output the rotation rate, attitude and the enabled state of the gyroscope as a Label
        GUI.Label(new Rect(500, 300, 200, 690), "Gyro rotation rate " + gyroInput.rotationRate, style);
        GUI.Label(new Rect(500, 400, 200, 690), "Gyro attitude" + gyroInput.attitude, style);
        GUI.Label(new Rect(500, 500, 800, 690), "Gyro enabled : " + gyroInput.enabled, style);
    }
}
