using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour
{

    public GameObject Mouth;
    public GameObject Body;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Vector3 bodyPos = hit.point;
            bodyPos.z = 1;
            //bodyPos.x = hit.point.x + 0.4f;

            Vector3 MouthPos = hit.point;
            MouthPos.z = 0.5f;

            Body.transform.position = Vector3.Lerp(bodyPos, Body.transform.position, 0.8f);
            Mouth.transform.position = Vector3.Lerp(MouthPos, Mouth.transform.position, 0.4f);
        }
    }
}
