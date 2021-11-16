using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject Door;
    private GameObject TimerCollider;
    [SerializeField] private Animator timeranimation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeranimation.SetBool("PlayerInTimer", true);
        }
    }
        
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeranimation.SetBool("PlayerInTimer", false);
        }
    }
}
