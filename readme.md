# UnityResourcesTest

Test project to demonstrate different behaviour of [**Resources.Load ()**](https://docs.unity3d.com/ScriptReference/Resources.Load.html) when loading Textures or Sprites.

**Tested with Unity 2017.1.0f3**

## Summary
The non-generic overload of [**Resources.Load ()**](https://docs.unity3d.com/ScriptReference/Resources.Load.html) returs always null when loading sprites:
 
```C#
var sprite = Resources.Load ("Sprites/sprite") as Sprite; // always null
```

Only the generic overload of [**Resources.Load ()**](https://docs.unity3d.com/ScriptReference/Resources.Load.html) returns valid sprites:

```C#
var sprite = Resources.Load <Sprite> ("Sprites/sprite") as Sprite; // fine
```

At the same time, there's no difference when loading textures:

```C#
var texture = Resources.Load ("Textures/texture") as Texture; // fine
var texture = Resources.Load <Texture> ("Textures/texture") as Texture; // also fine
```
	
## Unity Project

To reproduce this issue, open the Unity project, load the scene located in `Assets/Resources/Scenes` and hit Play.

There are four GameObjects in the scene to demonstrate the above mentioned scenarios:

- **SpriteLoader1**: Load a Sprite via `Resources.Load <Sprite> ()`
- **SpriteLoader2**: Load a Sprite via `Resources.Load ()`
- **TextureLoader1**: Load a Texture via `Resources.Load <Texture> ()`
- **TextureLoader2**: Load a Texture via `Resources.Load ()`

Where SpriteLoader2 fails to load the sprite:

![Editor AA 8](./doc/img1.png)

