using UnityEngine;

internal class TextSpawner : MonoBehaviour
{
    [SerializeField] private DropText dropTextPrefab;

    public void SpawnDropText(string text, Transform textTarget)
    {
        var dropText = Instantiate(dropTextPrefab, textTarget);
        dropText.NameText.text = text;
    }
}