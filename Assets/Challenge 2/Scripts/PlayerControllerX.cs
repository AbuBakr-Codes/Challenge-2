using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 1.0f; // first timer value
    private float waitTime = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //if update is called at a frame say 0.02 secs from one frame to another
        //Delay timer by adding up to make up a resetted timer until timer goes back to 1.0f 
        if (timer < waitTime)
        {
            timer += Time.deltaTime;
        }
        // On spacebar press, send dog
        //else if is used as it requires a condition and should only happen when if statement doesn't happen
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //Resets Timer after instantiating
            timer = 0;
        }
    }
}
