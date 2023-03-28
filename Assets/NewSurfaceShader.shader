Shader "Masked/Mask" {
 
	Properties{
         _MainTex ("Base (RGB), Alpha (A)", 2D) = "white" {}
      }
	SubShader {
		// Render the mask after regular geometry, but before masked geometry and
		// transparent things.
 
		Tags {"Queue" = "Transparent" }
 
		// Don't draw in the RGBA channels; just the depth buffer
 
		ColorMask 0
		ZWrite On
		Offset -1, -1
		Blend SrcAlpha OneMinusSrcAlpha
		// Do nothing specific in the pass:
 
		Pass {}
	}
}