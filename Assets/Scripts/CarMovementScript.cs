using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementScript : MonoBehaviour
{
    public GameObject[] wheels;
    public bool fourWheelDrive = true;

    public float maxMotorTorque; // max motor nyomaték
    public float maxSteeringAngle; // max kanyarodási szög
    public float maxBrakeTorque; // max fék nyomaték / fék erő
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
