using UnityEngine;
using System.Collections;

public class ControllerSource : ObjectSource 
{
	// Speed of 
	public Vector2 v2Speed = Vector2.zero;
	// Limit of 
	public float fLimit = 0f;
	
	// 90 units from the centre-point of the scene
	private Vector3 v3Distance = new Vector3(0f, 90f, 0f);
	
	
	public void _PositionSet()
	{
		Vector3 _v3PositionRotation = new Vector3(0f, _tTransform.position.y, 0f) - _tTransform.position;
		_tTransform.rotation = Quaternion.FromToRotation(Vector3.up, -_v3PositionRotation);
	}
	
	public void _RotationX(float _fX)
	{
		Vector3 _v3Rotation = new Vector3(_fX, 0f, 0f);
		_tTransform.rotation *= Quaternion.Euler(_v3Rotation);
	}
	
	
	
	public void _PositionX()
	{
		Vector3 _v3Move = _tTransform.rotation * v3Distance;
		_v3Move = new Vector3(_v3Move.x, _tTransform.position.y, _v3Move.z);
		_tTransform.position = _v3Move;
	}
	
	public void _PositionY(float _fY)
	{
		_tTransform.position = new Vector3(
			_tTransform.position.x,
			Mathf.Clamp(_tTransform.position.y + _fY, -fLimit, fLimit),
			_tTransform.position.z
			);
	}
}
