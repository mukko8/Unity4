using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0)){
        Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray,out hit,100f)){
            Debug.Log(hit.point);
            Destroy(hit.collider.gameObject);
        }
        /*
        foreach(RaycastHit hit in Physics.RaycastAll(ray)) {
            Destroy(hit.collider.gameObject);
        }
        */
        /*
        foreach (RaycastHit hit in Physics.SphereCastAll(ray,3f)) {
            Destroy(hit.collider.gameObject);
        }
        */
       } 
    }
}
