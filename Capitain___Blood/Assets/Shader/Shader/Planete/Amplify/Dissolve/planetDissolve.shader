// Made with Amplify Shader Editor
// Available at the Unity Asset Store - http://u3d.as/y3X 
Shader "planetDissolve"
{
	Properties
	{
		_Noise_Texture("Noise_Texture", 2D) = "white" {}
		_Main_Texture("Main_Texture", 2D) = "white" {}
		_Dissolve("Dissolve", Float) = 0
		_Bordure("Bordure", Float) = 0
		_Color_Dissolve("Color_Dissolve", Color) = (1,0,0,1)
		_Cutoff( "Mask Clip Value", Float ) = 0.5
		[HideInInspector] _texcoord( "", 2D ) = "white" {}
		[HideInInspector] __dirty( "", Int ) = 1
	}

	SubShader
	{
		Tags{ "RenderType" = "TransparentCutout"  "Queue" = "AlphaTest+0" "IsEmissive" = "true"  }
		Cull Back
		CGPROGRAM
		#pragma target 3.0
		#pragma surface surf Standard keepalpha addshadow fullforwardshadows 
		struct Input
		{
			float2 uv_texcoord;
		};

		uniform sampler2D _Main_Texture;
		uniform float4 _Main_Texture_ST;
		uniform sampler2D _Noise_Texture;
		uniform float4 _Noise_Texture_ST;
		uniform float _Dissolve;
		uniform float _Bordure;
		uniform float4 _Color_Dissolve;
		uniform float _Cutoff = 0.5;

		void surf( Input i , inout SurfaceOutputStandard o )
		{
			float2 uv_Main_Texture = i.uv_texcoord * _Main_Texture_ST.xy + _Main_Texture_ST.zw;
			o.Albedo = tex2D( _Main_Texture, uv_Main_Texture ).rgb;
			float2 uv_Noise_Texture = i.uv_texcoord * _Noise_Texture_ST.xy + _Noise_Texture_ST.zw;
			float4 tex2DNode10 = tex2D( _Noise_Texture, uv_Noise_Texture );
			float4 temp_cast_1 = (( _Dissolve + _Bordure )).xxxx;
			o.Emission = ( step( tex2DNode10 , temp_cast_1 ) * _Color_Dissolve ).rgb;
			o.Alpha = 1;
			clip( ( tex2DNode10 + (-0.6 + (( 1.0 - _Dissolve ) - 0.0) * (0.6 - -0.6) / (1.0 - 0.0)) ).r - _Cutoff );
		}

		ENDCG
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}
/*ASEBEGIN
Version=15900
-1920;942;1130;509;1404.238;293.239;2.020256;True;False
Node;AmplifyShaderEditor.RangedFloatNode;31;-816.862,179.2115;Float;False;Property;_Bordure;Bordure;3;0;Create;True;0;0;False;0;0;0.01;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.RangedFloatNode;11;-1484.563,439.7334;Float;False;Property;_Dissolve;Dissolve;2;0;Create;True;0;0;False;0;0;0.51;0;0;0;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleAddOpNode;32;-794.0711,270.6293;Float;False;2;2;0;FLOAT;0;False;1;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.SamplerNode;10;-1239.447,135.2091;Float;True;Property;_Noise_Texture;Noise_Texture;0;0;Create;True;0;0;False;0;None;00ddc1265ec46694c8e23aee035fb8c2;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.OneMinusNode;12;-1326.229,529.4432;Float;False;1;0;FLOAT;0;False;1;FLOAT;0
Node;AmplifyShaderEditor.ColorNode;20;-556.4311,250.4544;Float;False;Property;_Color_Dissolve;Color_Dissolve;4;0;Create;True;0;0;False;0;1,0,0,1;1,0,0,1;0;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.StepOpNode;16;-557.1184,31.53565;Float;True;2;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.TFHCRemapNode;13;-1153.305,524.2922;Float;False;5;0;FLOAT;0;False;1;FLOAT;0;False;2;FLOAT;1;False;3;FLOAT;-0.6;False;4;FLOAT;0.6;False;1;FLOAT;0
Node;AmplifyShaderEditor.SimpleMultiplyOpNode;19;-316.1874,75.00062;Float;False;2;2;0;COLOR;0,0,0,0;False;1;COLOR;0,0,0,0;False;1;COLOR;0
Node;AmplifyShaderEditor.SimpleAddOpNode;29;-609.3362,630.9385;Float;False;2;2;0;COLOR;0,0,0,0;False;1;FLOAT;0;False;1;COLOR;0
Node;AmplifyShaderEditor.SamplerNode;18;-340.5883,-244.1861;Float;True;Property;_Main_Texture;Main_Texture;1;0;Create;True;0;0;False;0;None;None;True;0;False;white;Auto;False;Object;-1;Auto;Texture2D;6;0;SAMPLER2D;;False;1;FLOAT2;0,0;False;2;FLOAT;0;False;3;FLOAT2;0,0;False;4;FLOAT2;0,0;False;5;FLOAT;1;False;5;COLOR;0;FLOAT;1;FLOAT;2;FLOAT;3;FLOAT;4
Node;AmplifyShaderEditor.StandardSurfaceOutputNode;0;348.6692,-48.24421;Float;False;True;2;Float;ASEMaterialInspector;0;0;Standard;planetDissolve;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;Back;0;False;-1;0;False;-1;False;0;False;-1;0;False;-1;False;0;Masked;0.5;True;True;0;False;TransparentCutout;;AlphaTest;All;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;True;0;False;-1;False;0;False;-1;255;False;-1;255;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;-1;False;2;15;10;25;False;0.5;True;0;0;False;-1;0;False;-1;0;0;False;-1;0;False;-1;0;False;-1;0;False;-1;0;False;0;0,0,0,0;VertexOffset;True;False;Cylindrical;False;Relative;0;;5;-1;-1;-1;0;False;0;0;False;-1;-1;0;False;-1;0;0;0;16;0;FLOAT3;0,0,0;False;1;FLOAT3;0,0,0;False;2;FLOAT3;0,0,0;False;3;FLOAT;0;False;4;FLOAT;0;False;5;FLOAT;0;False;6;FLOAT3;0,0,0;False;7;FLOAT3;0,0,0;False;8;FLOAT;0;False;9;FLOAT;0;False;10;FLOAT;0;False;13;FLOAT3;0,0,0;False;11;FLOAT3;0,0,0;False;12;FLOAT3;0,0,0;False;14;FLOAT4;0,0,0,0;False;15;FLOAT3;0,0,0;False;0
WireConnection;32;0;11;0
WireConnection;32;1;31;0
WireConnection;12;0;11;0
WireConnection;16;0;10;0
WireConnection;16;1;32;0
WireConnection;13;0;12;0
WireConnection;19;0;16;0
WireConnection;19;1;20;0
WireConnection;29;0;10;0
WireConnection;29;1;13;0
WireConnection;0;0;18;0
WireConnection;0;2;19;0
WireConnection;0;10;29;0
ASEEND*/
//CHKSM=65444272D05E200FF7B4F58BF8A6238EC6C68BEB