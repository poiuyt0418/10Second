using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PESMTextKill : MonoBehaviour
{
	public AudioSource bell;
	public GameObject target;
	public GameObject gameManager;

	void Start()
	{
		Destroy(gameObject, 2);
	}

	void OnDestroy()
	{
		bell.Play(0);
		Instantiate(target, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-3.0f, 3.0f), 0), Quaternion.identity, gameManager.transform);
		Instantiate(target, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-3.0f, 3.0f), 0), Quaternion.identity, gameManager.transform);
		Instantiate(target, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-3.0f, 3.0f), 0), Quaternion.identity, gameManager.transform);
		Instantiate(target, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-3.0f, 3.0f), 0), Quaternion.identity, gameManager.transform);
		Instantiate(target, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-3.0f, 3.0f), 0), Quaternion.identity, gameManager.transform);
		gameManager.GetComponent<Manager>().startTimer();
	}
}