using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject arObject;

    private const float AngleMin = 0f;
    private const float AngleMax = 360f;

    private float angle = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        arObject.transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
    }

    public void updateRotation(float sliderValue)
    {
        angle = sliderValue;

        if (arObject)
        {
            arObject.transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
        }

    }
}
