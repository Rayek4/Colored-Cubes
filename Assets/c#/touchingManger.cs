using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchingManger : MonoBehaviour
{
    public GameObject Cube;
    private string CubeTag, BaseTag;
    public Transform SmallprticalEffects;



    private void Start()
    {
        CubeTag = Cube.transform.tag;
        BaseTag = transform.tag;

    }

    private void Update()
    {

        float distance = Vector3.Distance(transform.position, Cube.transform.position);

        if (distance < 1.5)
        {
            transform.GetComponent<BoxCollider>().isTrigger = true;
            if (distance < 1)
            {
                this.enabled = false;
                Destroy(Cube.gameObject);
                Instantiate(SmallprticalEffects, transform.position, transform.rotation);

                transform.GetComponent<BoxCollider>().isTrigger = false;
            }
        }
    }
    
    
}