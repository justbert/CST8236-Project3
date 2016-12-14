using UnityEngine;
using System.Collections;

public class RotateAroundParent : MonoBehaviour
{
    public float period;

	// Use this for initialization
	void Start ()
	{
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
        transform.RotateAround(transform.parent.position,Vector3.up, 1/period*360/60*Time.deltaTime);
	}
}
