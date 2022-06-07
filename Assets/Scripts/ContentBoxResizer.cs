using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentBoxResizer : MonoBehaviour
{
    public GameObject contentBox;
    private void OnEnable() {
        RectTransform h = (RectTransform)transform;
        float textHeight = h.rect.height;

        RectTransform cb = (RectTransform)contentBox.transform;
        cb.sizeDelta = new Vector2(cb.rect.width, textHeight);

    }
}
