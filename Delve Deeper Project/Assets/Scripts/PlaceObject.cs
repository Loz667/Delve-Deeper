using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    [SerializeField] GameObject objectPrefab;
    [SerializeField] int chanceOfAppearance;
    [SerializeField] Maze.PieceType location;

    Maze thisMaze;

    public void Go()
    {
        thisMaze = GetComponent<Maze>();
        if (thisMaze == null) return;
        for (int z = 0; z < thisMaze.depth; z++)
            for (int x = 0; x < thisMaze.width; x++)
            {
                if (thisMaze.piecePlaces[x, z].piece == location && Random.Range(0, 100) < chanceOfAppearance)
                {
                    Instantiate(objectPrefab, thisMaze.piecePlaces[x, z].model.transform);
                }
            }
    }
}
