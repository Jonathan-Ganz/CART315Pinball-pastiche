using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionLight: MonoBehaviour
{
    public GameObject Ball = GameObject.Find("Ball");
    public float speed;
    public GameObject Light;
    public Light lightComp;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LightNode")
        {
            lightComp = col.collider.gameObject.GetComponent<Light>();
            lightComp.range = 20;
            lightComp.intensity = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
