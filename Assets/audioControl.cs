using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioControl : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    private void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    private void Awake()
    {
        volumeSlider = GameObject.Find("volume").GetComponent<Slider>();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }

    
}
