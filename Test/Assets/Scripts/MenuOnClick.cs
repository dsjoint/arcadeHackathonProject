using UnityEngine;
using System;

public class MenuOnClick : MonoBehaviour {
    public void OnClick() {
        Invoke("Load", 0.5f);
    }
 
    private void Load() {
        Application.LoadLevel("startMenu");
    }
}