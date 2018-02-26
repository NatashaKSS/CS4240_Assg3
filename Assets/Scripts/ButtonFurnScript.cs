using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFurnScript : MonoBehaviour {

    public FurnitureManager FurnitureManager;
    public GameObject furn;

    public void SelectFurn() {
        FurnitureManager.SetCurrSelectedFurn(furn);
        FurnitureManager.ResetButtons();
        FurnitureManager.SetButtonAs(gameObject, true);
    }
}
