using UnityEngine;
using System.Collections;

public class OSource : MonoBehaviour 
{
	public Transform _tTransform{ get; private set; }
	
	virtual public void Awake()
	{
		_tTransform = transform;
	}
}
