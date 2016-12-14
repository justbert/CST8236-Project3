using UnityEngine;
using System.Collections;

public class ChangeTimeScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Alpha1))
        {
            Time.timeScale = 0.1f;
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            Time.timeScale = 0.2f;
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            Time.timeScale = 0.3f;
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            Time.timeScale = 0.4f;
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            Time.timeScale = 0.5f;
        }

        if (Input.GetKey(KeyCode.Alpha6))
        {
            Time.timeScale = 0.6f;
        }

        if (Input.GetKey(KeyCode.Alpha7))
        {
            Time.timeScale = 0.7f;
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            Time.timeScale = 0.8f;
        }

        if (Input.GetKey(KeyCode.Alpha9))
        {
            Time.timeScale = 0.9f;
        }

        if (Input.GetKey(KeyCode.Alpha0))
        {
            Time.timeScale = 1.0f;
        }

    }
}
