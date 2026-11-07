using UnityEngine;
public class Stage1MazeGenerator : MonoBehaviour {
  public int size = 9; public GameObject wallPrefab; public GameObject floorPrefab; public GameObject valvePrefab; void Start(){ GenerateMaze(); PlaceValves(); }
  void GenerateMaze(){ int s = size; }
  void PlaceValves(){ PlaceValve(new Vector3(1.5f,0.5f,1.5f)); PlaceValve(new Vector3(7f,0.5f,3f)); PlaceValve(new Vector3(4f,0.5f,7f)); }
  void PlaceValve(Vector3 pos){ if (valvePrefab != null) Instantiate(valvePrefab, pos, Quaternion.identity); else GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = pos + Vector3.up*0.25f; }
}
