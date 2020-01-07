using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{

    public levelManager levelManager;
    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color",Color.green);
        levelManager.currentBoxCount++;
    }

    
}
