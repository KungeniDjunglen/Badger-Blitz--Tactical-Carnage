using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class AudioSlider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public void Audio_Slider()
    {
        AudioListener.volume = volumeSlider.value;

        Debug.Log("" + AudioListener.volume);
    }
}
