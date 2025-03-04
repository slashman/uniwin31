using UnityEngine;

public class MenuOption: MonoBehaviour {
    public GameObject menuObject;

    public void ToggleMenu() {
        menuObject.SetActive(!menuObject.activeSelf);
    }
}