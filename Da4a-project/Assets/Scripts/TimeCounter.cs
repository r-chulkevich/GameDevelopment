using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TimeCounter : MonoBehaviour {

    Text minuts;
    Text hours;
    string Minuts;
    string Hours;
    Image hunger;
    Image stamina;
    Image sprite;

    void Start() {
        minuts = GameObject.FindGameObjectWithTag("Minuts").GetComponent<Text>();
        hours = GameObject.FindGameObjectWithTag("Hours").GetComponent<Text>();
        hunger = GameObject.FindGameObjectWithTag("Hunger").GetComponent<Image>();
        sprite = GameObject.FindGameObjectWithTag("Sprite").GetComponent<Image>();
        stamina = GameObject.FindGameObjectWithTag("Stamina").GetComponent<Image>();
    }

	void Update () {
        Minuts = (Int32.Parse(Time.time.ToString().Substring(0, Time.time.ToString().LastIndexOf("."))) - 60 * (int)(Int32.Parse(Time.time.ToString().Substring(0, Time.time.ToString().LastIndexOf("."))) / 60)).ToString();
        if (Minuts.Length == 1)
            minuts.text = "0" + Minuts;
        else
            minuts.text = Minuts;
        if (Minuts.Equals("0")) {
            Hours = ((int)(Int32.Parse(Time.time.ToString().Substring(0, Time.time.ToString().LastIndexOf("."))) / 60)).ToString();
            if (Hours.Length == 1)
                hours.text = "0" + Hours;
            else
                hours.text = Hours;
        }
        hunger.fillAmount = hunger.fillAmount - 0.00005f;
        sprite.fillAmount = sprite.fillAmount - 0.00005f;
        stamina.fillAmount = stamina.fillAmount - 0.00002f;

    }
}
