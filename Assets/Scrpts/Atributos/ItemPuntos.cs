using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPuntos : MonoBehaviour
{

	[SerializeField] private int puntosBrindados = 100;
	[SerializeField] private AudioClip audioClip;


	private bool activado = false;
	private AudioSource audioSource;
	private SpriteRenderer spriteRenderer;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (activado) { return; }

		if (collision.gameObject.TryGetComponent<Puntos>(out Puntos puntos))
		{
			activado = true;
			puntos.SumarPuntos(puntosBrindados);
			spriteRenderer.enabled = false;
			Destroy(gameObject, audioClip.length);
		}

		if (audioClip == null) { return; }

		ReproducirSonido();

	}

	private void ReproducirSonido()
	{
		audioSource.PlayOneShot(audioClip);
	}
}




