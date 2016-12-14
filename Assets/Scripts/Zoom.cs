using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour
{

    public float maxIn;
    public float maxOut;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Plus) && transform.localPosition.z >= maxIn)
        {
            transform.localPosition.Set(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 0.1f);
        }

	    if (Input.GetKey(KeyCode.Plus) && transform.localPosition.z <= maxOut)
	    {
	        transform.localPosition.Set(transform.localPosition.x, transform.localPosition.y,
	            transform.localPosition.z + 0.1f);
	    }

	}
}
