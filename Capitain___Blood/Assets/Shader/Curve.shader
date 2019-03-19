Shader "Unlit/Curve"
{
    Properties
    {
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

		#define NOISE fbm
		#define NUM_NOISE_OCTAVES 5

        Pass
        {
		// By Morgan McGuire @morgan3d, http://graphicscodex.com
		// Reuse permitted under the BSD license.

		// All noise functions are designed for values on integer scale.
		// They are tuned to avoid visible periodicity for both positive and
		// negative coordinates within a few orders of magnitude.

		// For a single octave
		//#define NOISE noise

		// For multiple octaves
#define NOISE fbm


		// Properties
		const int octaves = 10;
	float lacunarity = 2.640;
	float gain = -0.360;


	float hash(float n) { return fract(sin(n) * 1e4); }
	float hash(vec2 p) { return fract(1e4 * sin(17.0 * p.x + p.y * 0.1) * (0.1 + abs(sin(p.y * 13.0 + p.x)))); }

	float noise(float x) {
		float i = floor(x);
		float f = fract(x);
		float u = f * f * (3.0 - 2.0 * f);
		return mix(hash(i), hash(i + 1.0), u);
	}



	float fbm(float x) {
		float amplitude = 0.952;
		float frequency = 0.08;
		float y;
		float shift = float(100);
		for (int i = 0; i < octaves; ++i)
		{
			y += amplitude * noise(frequency*x);
			frequency *= lacunarity;
			x = x * 2.0 + shift;
			amplitude *= gain;
		}
		return y;
	}




	void mainImage(out vec4 fragColor, in vec2 fragCoord) {
		float v = 0.0;

		// Visualize 1D, 2D, and 3D
		if (fragCoord.y > iResolution.y / 1000.0) {
			if (fragCoord.x < iResolution.x / 1.0) {
				// 1D
				float coord = fragCoord.x * 0.05 +
					// iTime * 5.0 
					-10.0;
				float height = NOISE(coord) * iResolution.y / 2.0;
				v = clamp((height - fragCoord.y + iResolution.y / 2.0) / (iResolution.y * 0.02), 0.0, 1.0);
			}

		}

		// Visualize with a fun color map	
		fragColor.rgb = pow(v, 1.55) * 1. * normalize(vec3(0.5, fragCoord.xy / iResolution.xy)) + vec3(v * 0.00);
	}
	}
	}
            }
            ENDCG
        }
    }
}
