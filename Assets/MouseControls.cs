﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControls : MonoBehaviour
{
    public Transform Y_Limiter;

    public GameObject Mouth;
    public GameObject Body;
    //public GameObject LeftEyeStar;
    //public GameObject RightEyeStar;
    //public GameObject Stars;

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
            //if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Water"))
            //{

            //}

            Vector3 bodyPos, MouthPos;

            if (hit.point.y >= Y_Limiter.position.y)
            {
                bodyPos = hit.point;
                bodyPos.z = 1;
                //move mouth position up a bit
                bodyPos.y = hit.point.y - 0.15f;

                MouthPos = hit.point;
                MouthPos.z = 0.5f;

                
            } else
            {
                bodyPos = hit.point;
                bodyPos.z = 1;
                bodyPos.y = Y_Limiter.position.y - 0.15f;

                MouthPos = hit.point;
                MouthPos.z = 0.5f;
                MouthPos.y = Y_Limiter.position.y;

            }

            Body.transform.position = Vector3.Lerp(bodyPos, Body.transform.position, 0.8f);
            Mouth.transform.position = Vector3.Lerp(MouthPos, Mouth.transform.position, 0.4f);
            //show eye star while eating
            //Vector3 LeftEyeStarPos = hit.point;
            //LeftEyeStarPos.z = -0.5f;
            //LeftEyeStar.transform.position = Vector3.Lerp(LeftEyeStarPos, LeftEyeStar.transform.position, -.5f);



        }

    }
}
