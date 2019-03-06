using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionLight: MonoBehaviour
{
    public GameObject Ball = GameObject.Find("Ball");
    public float speed;
    public GameObject Light;
    public Light lightComp;
    public Vector3 CheckPoint;
    public GameObject theball;

    // Start is called before the first frame update
    void Start()
    {
        CheckPoint= theball.transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "LightNode")
        {
            lightComp = col.collider.gameObject.GetComponent<Light>();
            CheckPoint = col.collider.gameObject.transform.position;
            lightComp.range = 20;
            lightComp.intensity = 5;
        }
    }

    public Vector3 GetRespawn()
    {
        return CheckPoint;

    }
    // Update is called once per frame
    void Update()
    {

    }
}
