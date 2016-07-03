using UnityEngine;
using System.Collections;

public class MovePlate : MonoBehaviour {
    public float speed = 5.0f;//the speed of plate
	// Use this for initialization	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxis("Horizontal");//get the horizontal input
        transform.Translate(Vector3.right * h * speed * Time.deltaTime);//move the plate
	}
}
