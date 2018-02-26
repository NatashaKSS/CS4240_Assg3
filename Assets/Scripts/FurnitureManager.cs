using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Responsible for managing what furniture items are rendered into the scene 
 * and how they are rendered by controlling the various furniture prefabs and 
 * furniture selecter GUI.
 */
public class FurnitureManager : MonoBehaviour {

    public GameObject HitCubeParent;
    public GameObject FurniturePlaceholder;
    public GameObject DefaultFurniture;
    public GameObject CurrSelectedFurniture;

	// Use this for initialization
	void Start () {
        
	}

    //=================================================
    // GETTERS & SETTERS
    //=================================================

    public GameObject GetCurrSelectedFurn() {
        return CurrSelectedFurniture;
    }

    public void SetCurrSelectedFurn(GameObject furn) {
        CurrSelectedFurniture = furn;
    }

    //=================================================
    // GENERATE FURNITURE
    //=================================================

    public void GenerateFurniture() {
        GameObject newFurniture = Instantiate(CurrSelectedFurniture);
        newFurniture.transform.SetPositionAndRotation(HitCubeParent.transform.position, Quaternion.AngleAxis(-90.0f, Vector3.right));
        // newFurniture.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f); // HitCubeParent's scale
    }

}
