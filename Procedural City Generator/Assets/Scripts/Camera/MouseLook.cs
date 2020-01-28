using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensitivity = 5.0f;
	public float flowing = 2.0f;
	GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
		mouseMovement = Vector2.Scale(mouseMovement, new Vector2(sensitivity* flowing,sensitivity * flowing));
		smoothV.x = Mathf.Lerp(smoothV.x,mouseMovement.x,1f /flowing);
		smoothV.y = Mathf.Lerp(smoothV.y,mouseMovement.y,1f/flowing);
		mouseLook += smoothV;
		
		transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
		character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x,character.transform.up);
    }
}
