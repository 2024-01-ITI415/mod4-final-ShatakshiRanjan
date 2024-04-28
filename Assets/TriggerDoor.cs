using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    private Animator _doorAnim;
    // Start is called before the first frame update
    void Start()
    {
        _doorAnim = GetComponent<Animator>();
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _doorAnim.SetTrigger("Close");
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _doorAnim.SetTrigger("Open");
        }

    }
}
