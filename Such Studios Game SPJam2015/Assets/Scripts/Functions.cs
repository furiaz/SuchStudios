using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

	public static Quaternion rotateTo(Vector3 rotating, Vector3 target){
		if (target.y > 0)
			return Quaternion.Euler (0, 0, Vector3.Angle (Vector3.right, target - rotating) + 90);
		else
			return Quaternion.Euler (0, 0, -Vector3.Angle (Vector3.right, target - rotating) + 90);
	}

}