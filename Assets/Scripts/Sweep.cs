using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sweep : MonoBehaviour
{
    [SerializeField]
    private GameObject doorPlane1;

   

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")

        StartCoroutine("doorRaise");

    }
        
    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.tag == "Player")

        StartCoroutine("doorLower");


        
    }
    private IEnumerator doorRaise()
    {
        for (int i = 0; i < 110; i++)

        {
            doorPlane1.gameObject.transform.position += new Vector3(0, 0, -0.3f);
            

            yield return new WaitForSeconds(0.01f);
        }
    }
    private IEnumerator doorLower()
    {
        for (int i = 0; i < 110; i++)

        {
            doorPlane1.gameObject.transform.position += new Vector3(0, 0, 0.3f);
            

            yield return new WaitForSeconds(0.01f);
        }
    }
}
