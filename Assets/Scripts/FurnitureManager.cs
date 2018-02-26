using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Responsible for managing what furniture items are rendered into the scene 
 * and how they are rendered by controlling the various furniture prefabs and 
 * furniture selecter GUI.
 */
public class FurnitureManager : MonoBehaviour {

    public GameObject HitCubeParent;
    public GameObject CurrSelectedFurniture;

    public GameObject[] Buttons;

	// Use this for initialization
	void Start () {
        ResetButtons();
	}

    public void ResetButtons() {
        foreach (GameObject button in Buttons) {
            SetButtonAs(button, false);
        }
    }

    public void SetButtonAs(GameObject button, bool isActive) {
        if (isActive) {
            // Toggle on
            button.transform.GetComponent<Image>().color = new Color32(68, 197, 74, 255);
        } else {
            // Toggle off
            button.transform.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
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
