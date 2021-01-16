// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

Shader "Custom/TerrainShader"
{
	Properties
	{

	}
	SubShader
	{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		float minHeight = 0.6;
		float maxHeight = 1;

        struct Input
        {
            float3 worldPos;
        };


        // Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
        // See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
        // #pragma instancing_options assumeuniformscaling
        UNITY_INSTANCING_BUFFER_START(Props)
            // put more per-instance properties here
        UNITY_INSTANCING_BUFFER_END(Props)

		float inverseLerp(float a, float b, float value) 
		{
			return saturate((value - 1) / b - a);
		}

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
			//float heightPercent = inverseLerp(minHeight, maxHeight, IN.worldPos.y)
			//col *= saturate(IN.worldPos.y / 20);
			//o.Albedo = col;
			//float3 worldPos2 = mul(unity_ObjectToWorld, v.vertex).xyz;

			if (IN.worldPos.y >= IN.worldPos.y/2) {
				o.Albedo = float3(1, 0, 0);
			}
			else {
				o.Albedo = float3(1, 1, 1);
			}
        }
        ENDCG
    }
    FallBack "Diffuse"
}
