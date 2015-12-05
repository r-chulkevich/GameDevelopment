using UnityEngine;
using System.Collections;

public class LocationChanger : MonoBehaviour {

    public Transform teleportTo;

    IEnumerator OnTriggerEnter2D(Collider2D other) {

        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
        PlayerMove pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();

        pm.isWaiting = true;
        yield return StartCoroutine(sf.FadeToBlack ());

        other.gameObject.transform.position = teleportTo.position;
        Camera.main.transform.position = teleportTo.position;

        pm.isWaiting = false;
        yield return StartCoroutine(sf.FadeToClear());
    }
}
