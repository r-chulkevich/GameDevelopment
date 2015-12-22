using UnityEngine;
using System.Collections;

public class KeepShower : MonoBehaviour {

    public GameObject button;
    public GameObject table;

    public void showInvent() {

        button.SetActive(false);
        table.SetActive(true);
    }

    public void hideInvent() {

        button.SetActive(true);
        table.SetActive(false);
    }
}
