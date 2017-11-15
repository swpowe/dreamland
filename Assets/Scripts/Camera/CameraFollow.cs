using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smoothing = 5f;

	Vector3 offset;

	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		offset = transform.position - target.position;
	}

	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		Vector3 targetCamPos = target.position + offset;
		transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
	}

}
