using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update
    RaycastHit hit;
    public LayerMask mask;
    public levelManager levelManager;
    
    Vector3 targetPosition;
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position,targetPosition,Time.deltaTime*10);
        if(!levelManager.isGameActive) return;
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("right");
            if(Physics.Raycast(transform.position,Vector3.right,out hit,Mathf.Infinity,mask))
            {
                Debug.Log(hit.transform.name);
                targetPosition = hit.transform.position-Vector3.right;
            }
        }else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("left");
             if(Physics.Raycast(transform.position,Vector3.left,out hit,Mathf.Infinity,mask))
            {
                Debug.Log(hit.transform.name);
                targetPosition= hit.transform.position-Vector3.left;
            }
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up");
             if(Physics.Raycast(transform.position,Vector3.forward,out hit,Mathf.Infinity,mask))
            {
                Debug.Log(hit.transform.name);
                targetPosition= hit.transform.position-Vector3.forward;
            }
        }else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
             if(Physics.Raycast(transform.position,Vector3.back,out hit,Mathf.Infinity,mask))
            {
                Debug.Log(hit.transform.name);
                targetPosition = hit.transform.position-Vector3.back;
            }
            Debug.Log("down");
        }

    }
}
