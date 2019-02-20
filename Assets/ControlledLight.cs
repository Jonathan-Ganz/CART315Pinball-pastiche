using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlledLight : MonoBehaviour
{
    public GameObject Ball = GameObject.Find("Ball");
    public float speed;
    public GameObject Light;
    public Light lightComp; 

    // Start is called before the first frame update
    void Start()
    {
        lightComp = GameObject.Find("Ball").GetComponent<Light>();
        float LightIntensity = lightComp.intensity;
        float LightRange = lightComp.range;
    }

    // Update is called once per frame
    void Update()
    {
        float LightIntensity = lightComp.intensity;
        float LightRange = lightComp.range;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        LightIntensity = (Mathf.Abs(movement.x) + Mathf.Abs(movement.y) + Mathf.Abs(movement.z)) * speed/2 + 1;
        //make sure no matter the direction it is always a positive number
        LightRange = (Mathf.Abs(movement.x) + Mathf.Abs(movement.y) + Mathf.Abs(movement.z)) * speed * 2 + 5;
        lightComp.intensity = LightIntensity;
        lightComp.range = LightRange;
    }
}
