using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	
	private UISlider slider;
	
	// Use this for initialization
	void Start () {
		slider = GetComponent<UISlider>();
	}
	
	// Update is called once per frame
	void Update () {
		print ("player health: " + PlayerCollision.health);
		slider.sliderValue = PlayerCollision.health/100f;
		slider.ForceUpdate();
	}
}
