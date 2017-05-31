using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBehavior : MonoBehaviour {

public float health = 100f; 
public Text healthUI;
public float damagePerTime = 1f;
public float timeToDamage = 1f;

public int forceToApplyJump;
public int forceToApply;
private float totalTime;

private Vector3 beginPosition;

	// Use this for initialization
	void Start () {
		Debug.Log("Hola!");
		totalTime = 0;
		beginPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		healthUI.text = "Health:"+ health;
		

		if(totalTime >= timeToDamage){
			totalTime = 0;
			health = health - damagePerTime;
		}else{
			totalTime += Time.deltaTime;
		}

		if(Input.GetKey(KeyCode.D)){
			this.GetComponent<Rigidbody2D>().AddForce(Vector2.right*forceToApply,ForceMode2D.Force);
		}

		if(Input.GetKey(KeyCode.A)){
			this.GetComponent<Rigidbody2D>().AddForce(Vector2.right*-forceToApply,ForceMode2D.Force);
		}

		if(Input.GetKey(KeyCode.Space)){
			this.GetComponent<Rigidbody2D>().AddForce(Vector2.up*forceToApplyJump,ForceMode2D.Force);
		}
	}

	/// <summary>
	/// LateUpdate is called every frame, if the Behaviour is enabled.
	/// It is called after all Update functions have been called.
	/// </summary>
	void LateUpdate()
	{
		
	}

	 /// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		
	}

	void Awake () {
		Debug.Log("Adios");

	}

	public void resetPlayer()
	{
		transform.position = beginPosition;

	}

}
