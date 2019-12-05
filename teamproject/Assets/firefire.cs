using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class firefire : MonoBehaviour
{
    public Text status;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
           status = gameObject.GetComponentInChildren<Text>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("fire"))
        {
            other.gameObject.SetActive (false);
   
        }
        
        if (other.gameObject.CompareTag("orange"))
        {
            status.text = "Choose another one";
        }
    }

    // Update is called once per frame
    void Update()
    {
        status.text=" ";
    }
}
