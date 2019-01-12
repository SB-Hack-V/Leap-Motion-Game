using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class HandCollision : MonoBehaviour
{
    Controller controller = new Controller();

    private void OnTriggerEnter(Collider other)
    {
        // Grab the current frame info
        Frame frame = controller.Frame();

        // Detect hand gesture
        foreach (Hand hand in frame.Hands)
        {
            if (hand.IsRight)
            {
                //Debug.Log("Right hand detected!");
            }
            else
            {
                //Debug.Log("Right hand detected!");
            }
            if (!hand.Fingers[0].IsExtended &&
                !hand.Fingers[1].IsExtended &&
                !hand.Fingers[2].IsExtended &&
                !hand.Fingers[3].IsExtended &&
                !hand.Fingers[4].IsExtended &&
                /*hand.PalmNormal.y > -0.5*/)
            {
                Debug.Log("x: " + hand.PalmNormal.x + "y: " + hand.PalmNormal.x + "z: " + hand.PalmNormal.z);
                Debug.Log("Fist detected");
            }
                
            else if (hand.Fingers[0].IsExtended &&
                hand.Fingers[1].IsExtended &&
                hand.Fingers[2].IsExtended &&
                hand.Fingers[3].IsExtended &&
                hand.Fingers[4].IsExtended &&
                /*hand.PalmNormal.y > -0.5 && hand.PalmNormal.y < 0.5*/)
            {
                Debug.Log("Palm detected");
            }
                
        }
    }
}