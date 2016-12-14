using UnityEngine;
using System.Collections;

public class RotateSelf : MonoBehaviour
{

    public float period;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(transform.up, 1/period*360/60*365*Time.deltaTime);

    }
}
