using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDetect : MonoBehaviour
{
    public float speed = 5;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Item2")
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, other.gameObject.transform.position, step);
        }
    }
}
