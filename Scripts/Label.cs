using UnityEngine;
using TMPro;

public class Label : MonoBehaviour
{
    private TMP_Text text;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
    } 

    public void SetText(string text) {
        this.text.text = text;
    }

    public void AddText(string text) {
        this.text.text += text;
    }

    public void ShiftText(string text) {
        this.text.text = text + this.text.text;
    }

    public void Clear() {
        text.text = "";
    }
}
