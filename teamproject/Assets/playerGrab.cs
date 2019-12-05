using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerGrab : MonoBehaviour
{
    public GameObject water;
    public GameObject myHand;
    bool inHands = false;
    Vector3 waterPos;
    Collider waterCol;
    Rigidbody waterRb;
    Camera cam;
    public float handPower;




    // Start is called before the first frame update
    void Start()
    {
        //waterPos = water.transform.position;
        waterCol = water.GetComponent<SphereCollider>();
        waterRb = water.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();


    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
                {
                          if (!inHands)
                          {
                            water.transform.SetParent(myHand.transform);
                            water.transform.localPosition = new Vector3(0, -0.6f, 0);
                            waterCol.isTrigger = true;
                            waterRb.useGravity = false;
                            waterRb.velocity = Vector3.zero;


                            }
                            else
                           {
                            water.transform.SetParent(null);
                            //water.transform.localPosition = waterPos;
                            this.GetComponent<playerGrab>().enabled = false;
                            waterCol.isTrigger = false;
                            waterRb.useGravity = false;
                            waterRb.velocity = cam.transform.rotation * Vector3.zero * handPower;


                           }
                         inHands = !inHands;
        }


    }
}
