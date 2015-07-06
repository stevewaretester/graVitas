using UnityEngine;
using System.Collections;

public class Player : ControllerSource
{
	public Transform tModel = null;
	public float fRotation = 1f;
	
	private float fDirection = 0f;
	
	private void Start()
	{
		_PositionSet();
		_PositionX();
	}
	
	private void Update()
	{
		#region Player Input
		Vector2 v2Input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		
		if(v2Input != Vector2.zero)
		{
			v2Input = new Vector2(v2Input.x * v2Speed.x, v2Input.y * v2Speed.y) * Time.deltaTime;
		
			_RotationX(v2Input.x);
			_PositionX();
			_PositionY(v2Input.y);
		}
		#endregion Player Input
		
		if(v2Input.x != fDirection && v2Input.x != 0f)
		{
			fDirection = v2Input.x;
		}
		
		if(fDirection < 0f)
		{
			LookRotationLeft();
		}
		else
		{
			LookRotationRight();
		}
	}
	
	private void LookRotationLeft()
	{
		tModel.localRotation = Quaternion.Slerp(tModel.localRotation, Quaternion.Euler(new Vector3(180f, 0f, 0f)), fRotation * Time.deltaTime);
	}
	
	private void LookRotationRight()
	{
		tModel.localRotation = Quaternion.Slerp(tModel.localRotation, Quaternion.Euler(new Vector3(0f, 0f, 0f)), fRotation * Time.deltaTime);
	}
}
