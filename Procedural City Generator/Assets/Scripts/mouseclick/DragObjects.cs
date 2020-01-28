using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
	private Vector3 mOffset; 
	private float mZCoord;
	void OnMouseDown(){
		mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
		
		mOffset = gameObject.transform.position - GetMouseWorldPos();
		
	}
	private Vector3 GetMouseWorldPos(){
		//coordinates(x,y)
		Vector3 mousePoint = Input.mousePosition;
		//z coordinate of game object on screen
		mousePoint.z = mZCoord;
		return Camera.main.ScreenToWorldPoint(mousePoint);
	}
  void OnMouseDrag(){
	  transform.position = GetMouseWorldPos() + mOffset;
  }
}
