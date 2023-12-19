using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEngine.Mathf;

public class AudioText : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] TMP_Text audioText;
    
    void Update()
    {
        audioText.text = ("" + Mathf.Floor(volumeSlider.value));
    }
}
