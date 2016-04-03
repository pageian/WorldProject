using UnityEngine;
using System.Collections;

public class rotateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		var e = GameObject.Find("E");
		var k2 = GameObject.Find("K2Title");
		var k = GameObject.Find("K");
		var l = GameObject.Find("L");
		var m = GameObject.Find("M");

		e.SetActive(false);
		k2.SetActive(false);
		k.SetActive(false);
		l.SetActive(false);
		m.SetActive(false);

	}

	// Update is called once per frame
	void Update () {

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 rotation = new Vector3(vertical * Time.deltaTime * 100, horizontal * Time.deltaTime * 100, 0);
		transform.Rotate(rotation);

	}
}
