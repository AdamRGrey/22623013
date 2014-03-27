using UnityEngine;
using System.Collections;

public class billboardChildtoCamera : MonoBehaviour
{

    public Transform toRotate;
    public GameObject toFace;

	void Update () {
	    toRotate.transform.LookAt(toFace.transform);
	}
}
