using UnityEngine;

public class Window: MonoBehaviour {
    public delegate void OnHideDelegate();
    public OnHideDelegate OnHide;
    public void Hide(){
        gameObject.SetActive(false);
        if  (OnHide != null) {
            OnHide();
        }
    }

    public void Show(){
        gameObject.SetActive(true);
    }
}