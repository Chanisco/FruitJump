using UnityEngine;
using System.Collections;

public class SpriteAnimate : MonoBehaviour {
	string mainTex = "_MainTex";

	public void Animate(int nrOfColumns, int nrOfRow, int nrOfCells, int framesPerSecond, int colNumber, int rowNumber) {
		
		int index = (int)(framesPerSecond * Time.time);
		index = index % nrOfCells;
		
		//calculate the tile size
		float sizeX = 1f / nrOfColumns;
		float sizeY = 1f / nrOfRow;
		Vector2 size = new Vector2(sizeX, sizeY);
		
		//calc. horizontal & vertical index
		float uIndex = index % nrOfColumns;
		float vIndex = index / nrOfColumns;
		
		// size the tile so you can get the image well
		float offsetX = (uIndex + colNumber) * size.x;//1f / nrOfColumns * uIndex;
		float offsetY = (vIndex + rowNumber) * size.y;//1f / nrOfRow * vIndex;
		Vector2 offset = new Vector2(offsetX , offsetY);
		
		renderer.material.SetTextureScale(mainTex, size);
		renderer.material.SetTextureOffset(mainTex, offset);
		
		Debug.Log("de uindex =" + uIndex);
		Debug.Log ("de vIndex =" + vIndex);
	}
}
