using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Move : MonoBehaviour
{
    Camera cam;
    Collider planecollider;
    RaycastHit hit;
    Ray ray;
    GameObject targetObj;
    static int speed = 5;

    public Vector3 worldPosition;
    void Start()
    {
        // cam = GameObject.Find("Camera").GetComponent<Camera>();
        // planecollider = GameObject.Find("Terrain").GetComponent<Collider>();
    }

    void Update()
    {

      Plane plane = new Plane(Vector3.up, 0);

      float distance;

      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if (plane.Raycast(ray, out distance))
      {
        worldPosition = ray.GetPoint(distance);
      }
      if (Input.GetMouseButton(0)){
        transform.LookAt(new Vector3(worldPosition.x, transform.position.y, worldPosition.z));
      }else
      {
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
          transform.forward = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        }
      }

      // var targetObj = worldPosition;
      // var targetRotation = Quaternion.LookRotation( GameObject.FindWithTag("Player").transform.position - transform.position);

      // // Smoothly rotate towards the target point.
      // transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);

        //transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));
        // if (Input.GetMouseButton(0))
        // {
            // ray = cam.ScreenPointToRay(Input.mousePosition);
            // if (Physics.Raycast(ray, out hit))
            // {
            //     if (hit.collider == planecollider)
            //     {
            //         //transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * 5);
            //         transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            //     }
            // }

            // var targetObj = cam.ScreenPointToRay(Input.mousePosition);
            // var targetRotation = Quaternion.LookRotation( GameObject.FindWithTag("Player").transform.position - transform.position);

            // // Smoothly rotate towards the target point.
            // transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        // }else
        // {
          // if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
          // {
          //   transform.forward = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
          // }
        // }
    }
}
