using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {


    public GameObject cropToSpawn;
    //public object SpawnerObj;
    Rigidbody2D rbody;
    public float distance = 4.5f;
    public bool isWaiting = false;
    // Use this for initialization
    void Start () {
        Transform pm = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        PlayerMove tt = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>(); 
    }

    // Update is called once per frame
    void Update () {
        
        if (Input.GetMouseButtonDown(0))
        {
           
            
            //pm.position;
            SpawnCrop(new Vector2(pm.position.x,pm.position.y));
        }

    }
    void SpawnCrop(Vector2 pos)
    {
        {

            int x = 0;
            Vector2 napr = new Vector2(0f, 0f);
            switch ((int)tt.MoveSide)
            {
                case 0:
                    {
                        napr = new Vector2(-0.1f, 0.0f);
                    };
                    break;

                case 1:
                    {
                        napr = new Vector2(0.0f, 0.1f);

                    };
                    break;

                case 2:
                    {
                        napr = new Vector2(0.1f, 0.0f);
                    };
                    break;

                case 3:
                    {
                        napr = new Vector2(0.0f, -0.1f);
                    };
                    break;

            };
            //  if (napr + rbody.position)
            {
                GameObject Crop = (GameObject)Instantiate(cropToSpawn);
                //napr.x = 0f;
               // Vector2 pos = Input.mousePosition;
                //Crop.transform.position = rbody.position + napr;         
                Crop.transform.position = pos+napr;
            }
        }
        //  Get 
    }
}
