Shader "Unlit/NormalColor"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _RatioR  ("���������� ��������", float) = 0.333
        _RatioG  ("���������� ��������", float) = 0.333
        _RatioB  ("���������� ������", float) = 0.333
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
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

            fixed _RatioR;
            fixed _RatioG;
            fixed _RatioB;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                fixed pal = (col.x*_RatioR+col.y*_RatioG+col.z*_RatioB);
                col = fixed4(pal,pal,pal,1);
                return col;
            }
            ENDCG
        }
    }
}
