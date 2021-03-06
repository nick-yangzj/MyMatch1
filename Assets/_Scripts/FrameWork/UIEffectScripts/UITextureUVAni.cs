using UnityEngine;
using System.Collections;

public class UITextureUVAni : MonoBehaviour {
    private UITexture uiTexture;
    public float speed = 1.0f;
    private float x = 0;
	// Use this for initialization
	void Awake () {
        uiTexture = GetComponent<UITexture>();
	}
	
	// Update is called once per frame
	void Update () {
        if (uiTexture)
        {
            x += speed * Time.deltaTime*0.1f;
            uiTexture.uvRect = new Rect(x%1, 0, 1, 1);
        }
	}
}
