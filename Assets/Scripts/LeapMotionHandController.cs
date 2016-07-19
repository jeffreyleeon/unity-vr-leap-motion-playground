using UnityEngine;
using System.Collections;
using Leap;

public class LeapMotionHandController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Controller controller = new Controller ();
		Frame frame = controller.Frame();
		if(frame.Hands.Count > 0) {
			HandList hands = frame.Hands;
			Hand firstHand = hands [0];
			Debug.Log ("Hand id: " + firstHand.Id);
		}
	}

	void OnHandFound( Hand h )
	{
		Debug.Log ("Hand found");
	}
}
