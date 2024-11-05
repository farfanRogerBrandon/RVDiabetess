using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyroscopy : MonoBehaviour
{

    public GameObject VrCameras;

    public float initialPosy = 0f;
    public float gyrosPositionY = 0f;
    public float calibrateToYPos = 0f;
    public bool gameStart;
    void Start()
    {
        Input.gyro.enabled = true;
        initialPosy = VrCameras.transform.eulerAngles.y;

    }

    void Update()
    {
        ApplyGyroscopeRotatiom();
        ApplyCalibration();
        if (gameStart)
        {
            Invoke("LetsCalibrateY", 3f);
            gameStart = false;
        }
    }

    private void ApplyGyroscopeRotatiom()
    {
        VrCameras.transform.rotation = Input.gyro.attitude;
        VrCameras.transform.Rotate(0f, 0f, 180f, Space.Self);
        VrCameras.transform.Rotate(90f, 180f, 0f, Space.World);
        gyrosPositionY = VrCameras.transform.eulerAngles.y;
    }

    private void ApplyCalibration()
    {
        VrCameras.transform.Rotate(0f, -calibrateToYPos, 0f, Space.World);


    }
    void LetsCalibrateY()
    {
        calibrateToYPos = gyrosPositionY - initialPosy;

    }
}