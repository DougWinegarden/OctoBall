using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouthScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject);

        if (other.collider.transform.GetComponent<BallScript>())
        {
            //other.collider.transform.localScale.x -= 0.01;
            //other.collider.transform.localScale.z -= 0.01;

            Vector3 tempVect = other.collider.transform.localScale;
            tempVect.x -= 0.01f;
            tempVect.z -= 0.01f;

            other.collider.transform.localScale = tempVect;
            
        }

        if(other.collider.transform.localScale.x < 0.2)
        {
            Destroy(other.collider.gameObject);
        }
    }
}
