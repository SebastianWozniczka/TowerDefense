using UnityEngine;
using System.Collections;
using System.Threading;

public class CarrotSpawner : MonoBehaviour {

	private float ok;

	/// <summary>
	/// Carrot prefab
	/// </summary>
	public GameObject Carrot,Banana;

	public void StartCarrotSpawning()
	{
		StartCoroutine(SpawnCarrots());
	}

	public void StopCarrotSpawning()
	{
		StopAllCoroutines();
	}
	private IEnumerator SpawnCarrots()
	{
		while (true)
		{
			//select a random position
			float X = Random.Range(100, Screen.width - 100);
			Vector3 randomPosition = Camera.main.ScreenToWorldPoint(new Vector3(X, 0, 0));
			//create and drop a carrot
			
			
				GameObject carrot = Instantiate(Carrot,
					new Vector3(randomPosition.x, transform.position.y, transform.position.z),
					Quaternion.identity) as GameObject;

                carrot.GetComponent<Carrot>().FallSpeed = Random.Range(1f, 3f);

			ok += Time.deltaTime;
			if (ok > 1)
			{
				GameObject banan = Instantiate(Banana,
					new Vector3(randomPosition.x, Banana.transform.position.y, Banana.transform.position.z),
					Quaternion.identity);
				ok = 0;
			}
			

			
			//wait for random seconds, based on level parameters
			yield return new WaitForSeconds
				(Random.Range(GameManager.Instance.MinCarrotSpawnTime, 
				GameManager.Instance.MaxCarrotSpawnTime));
		}
	}
	

}
