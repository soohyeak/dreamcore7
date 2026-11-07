using UnityEngine; public class Stage2Env : MonoBehaviour { public Color skyColor = Color.red; void Start(){ if(RenderSettings.skybox != null) RenderSettings.skybox.SetColor("_Tint", skyColor); } }
