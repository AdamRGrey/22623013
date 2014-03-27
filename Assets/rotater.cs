using UnityEngine;
using System.Collections;

public class rotater : MonoBehaviour
{

    public float howMuch = 15.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        
	    transform.Rotate(Vector3.up, howMuch*Time.fixedDeltaTime);
	}
}
