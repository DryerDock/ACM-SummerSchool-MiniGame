using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class StreamingAssetsManager : MonoBehaviour
{
    public IEnumerator LoadSprite(string fileName,System.Action<Sprite> onLoaded)
    {
        string path = Path.Combine(Application.streamingAssetsPath, fileName);

        using UnityWebRequest request = UnityWebRequestTexture.GetTexture("file://" + path);

        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Could not load: " + fileName);
            yield break;
        }

        Texture2D texture = DownloadHandlerTexture.GetContent(request);

        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        onLoaded?.Invoke(sprite);
    }
}