using UnityEngine;

public class TextureLoader : MonoBehaviour {
	
	public LoadType loadType;

	void Start () {
		var cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		var meshRenderer = cube.GetComponent <MeshRenderer> ();

		switch (loadType) {
		case LoadType.GenericOverloadOn: 
			meshRenderer.material.mainTexture = Resources.Load <Texture> ("Textures/S") as Texture;
			break;
		case LoadType.GenericOverloadOff: 
			meshRenderer.material.mainTexture = Resources.Load ("Textures/S") as Texture;
			break;
		}

		cube.transform.parent = this.transform;
		cube.transform.localPosition = Vector3.zero;
	}
}
