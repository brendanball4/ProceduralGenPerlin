using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class TerrainData : UpdateableData
{
	public float uniformScale = 2f;
	public bool useFlatShading;
	public bool useFalloff;

	public float meshHeightMultiplier;
	public AnimationCurve meshHeightCurve;
}
