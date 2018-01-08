using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {

    public GameObject Mouth;
    public GameObject Body;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var touch = Input.touches[0];

        if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved)
        {
            // Construct a ray from the current touch coordinates
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out hit))
            {
                Vector3 bodyPos = hit.point;
                bodyPos.z = 1;

                Vector3 MouthPos = hit.point;
                MouthPos.z = 0.5f;

                Body.transform.position = Vector3.Lerp(bodyPos, Body.transform.position, 0.9f);
                Mouth.transform.position = Vector3.Lerp(MouthPos, Mouth.transform.position, 0.3f);
            }
        }
    }
}
