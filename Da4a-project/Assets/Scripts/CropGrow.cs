using UnityEngine;
using System.Collections;

public class CropGrow : MonoBehaviour {


    public bool grow = false;
    public int timetoGrow;// in days
    public int timetoDie;// in seconds
    public int dehydrationRate;
    public int hydration = 0;
    public int growstage = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	// if(NewDay)
        {
            growstage += 1;
            //Anim change
        }
        hydration -= dehydrationRate;
	}
}
