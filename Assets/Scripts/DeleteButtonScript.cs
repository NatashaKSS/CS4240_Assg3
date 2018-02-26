using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButtonScript : MonoBehaviour {

    private GameObject camera;
    private GameObject thisFurniture;

	void Start () {
        thisFurniture = transform.parent.transform.parent.gameObject;
        camera = GameObject.Find("Main Camera");
	}

    private void Update() {
        transform.LookAt(camera.transform);
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
    }

    public void DeleteThisFurniture() {
        Destroy(thisFurniture, 0.5f);
    }

}
