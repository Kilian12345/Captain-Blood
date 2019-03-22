﻿Shader "Unlit/Planete_SH"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}

////////////////////// PIXELISE
		_PixelNumberX("Pixel number along X", float) = 500
		_PixelNumberY("Pixel number along X", float) = 500
    }
    SubShader
		{
			Tags { "RenderType" = "Opaque" }
			LOD 100

			Pass
			{
				CGPROGRAM
				#pragma vertex vert
				#pragma fragment frag
				// make fog work
				#pragma multi_compile_fog

				#include "UnityCG.cginc"

				struct appdata
				{
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
				};

				struct v2f
				{
					float2 uv : TEXCOORD0;
					UNITY_FOG_COORDS(1)
					float4 vertex : SV_POSITION;
				};

				sampler2D _MainTex;
				float4 _MainTex_ST;

				v2f vert(appdata v)
				{
					v2f o;
					o.vertex = UnityObjectToClipPos(v.vertex);
					o.uv = TRANSFORM_TEX(v.uv, _MainTex);
					UNITY_TRANSFER_FOG(o,o.vertex);
					return o;
				}

				fixed4 frag(v2f i) : SV_Target
				{
					// sample the texture
					fixed4 col = tex2D(_MainTex, i.uv);
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG
				}

			Pass {


					CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

					sampler2D _MainTex;
					float _PixelNumberX;
					float _PixelNumberY;

					struct v2f {
						half4 pos : POSITION;
						half2 uv : TEXCOORD0;
					};

					float4 _MainTex_ST;

					v2f vert(appdata_base v) {
						v2f o;
						o.pos = UnityObjectToClipPos(v.vertex);
						o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
						return o;
					}


					half4 frag(v2f i) : COLOR{

						half ratioX = 1 / _PixelNumberX;
					half ratioY = 1 / _PixelNumberY;
					half2 uv = half2((int)(i.uv.x / ratioX) * ratioX, (int)(i.uv.y / ratioY) * ratioY);


					return tex2D(_MainTex, uv);
					}

						ENDCG
				}
		}
	
		FallBack "Diffuse"
        

    }
