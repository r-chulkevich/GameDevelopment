using UnityEngine;
using System.Collections;

public class NpcDialog : MonoBehaviour {

    public GameObject npcDl;
    public GameObject second;

    void OnTriggerEnter2D(Collider2D second) {
        PlayerMove pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        npcDl.SetActive(true);
        pm.isWaiting = true;
    }

    public void goOut() {
        PlayerMove pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        npcDl.SetActive(false);
        pm.isWaiting = false;
    }

    public void makeChange() {

        //
    }
}
