using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{

	[SerializeField]
	private Material starting_color;
	[SerializeField]
	private Material selected_color;
    // Start is called before the first frame update
	private MeshRenderer myRend;
	[HideInInspector]
	
	public bool currentlySelected = false;
	
    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
		ClickMe();
		
		
    }

  public void ClickMe()
{
	 if(currentlySelected==false)
	 {
		myRend.material = starting_color;
		
	 }
	 
	 else
	 {
		 myRend.material =selected_color; 
		 
	 }
	 
}
	 
}
