using UnityEngine;
using System.Collections;

public class BallContraler : MonoBehaviour {
    public float thrust = 40.0f;
    private Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            Application.Quit();
        }
	}
    void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(new Vector3(Random.Range(-0.2f, 0.2f), 1.0f, 0) * thrust);
    }
}
