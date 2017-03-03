using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        InstantiateBall();
    }


    void createRgObject()
    {

        GameObject instance = Instantiate(ballPrefab);
        Rigidbody rb = instance.GetComponent<Rigidbody>();

    }

    void InstantiateBall()
    {
        float speed = 5.0f;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * speed;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * speed;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * speed;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * speed;
        }
    }

}
