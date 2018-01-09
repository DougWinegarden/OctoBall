using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

    public float delay;

    private float timer;

    // Use this for initialization
    void Start () {
        timer = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (timer < Time.time)
        {
            timer = Time.time + delay;
            // create random x for vector3, set y and z
            //Vector3 randPos = new Vector3(Random.Range(-3f, 3f), 10, -1f);

            Instantiate(ballPrefab, transform.position, ballPrefab.transform.rotation);
        }
    }
}
