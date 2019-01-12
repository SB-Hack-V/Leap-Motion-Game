using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class HandCollision : MonoBehaviour
{
    Controller controller = new Controller();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HandR"))
        {
            //Debug.Log("Right hand detected");
            // Grab the current frame data
            Frame frame = controller.Frame();

            // Detect hand gesture
            foreach (Hand hand in frame.Hands)
            {
                if (!hand.Fingers[0].IsExtended &&
                    !hand.Fingers[1].IsExtended &&
                    !hand.Fingers[2].IsExtended &&
                    !hand.Fingers[3].IsExtended &&
                    !hand.Fingers[4].IsExtended)
                    Debug.Log("Right fist detected");
                else if (hand.Fingers[0].IsExtended &&
                    hand.Fingers[1].IsExtended &&
                    hand.Fingers[2].IsExtended &&
                    hand.Fingers[3].IsExtended &&
                    hand.Fingers[4].IsExtended)
                    Debug.Log("Right palm detected");

            }
        }
    }
}