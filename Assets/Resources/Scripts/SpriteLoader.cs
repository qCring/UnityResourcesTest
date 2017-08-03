using UnityEngine;

public class SpriteLoader : MonoBehaviour {

	public LoadType loadType;

	void Start () {
		var spriteRenderer = gameObject.AddComponent <SpriteRenderer> ();

		switch (loadType) {
		case LoadType.GenericOverloadOn: 
			spriteRenderer.sprite = Resources.Load <Sprite> ("Sprites/S") as Sprite;
			break;
		case LoadType.GenericOverloadOff: 
			spriteRenderer.sprite = Resources.Load ("Sprites/S") as Sprite;
			break;
		}
	}
}
