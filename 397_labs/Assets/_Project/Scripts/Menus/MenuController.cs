using UnityEngine;
using UnityEngine.UI;

namespace WebGame397
{
    public class MenuController : MonoBehaviour
    {

        [SerializeField] private Button playBtn;
        [SerializeField] private Button loadBtn;
        [SerializeField] private Button optionsBtn;
        [SerializeField] private Button quitBtn;
        [SerializeField] private SceneController sceneController;

        private void Start()
        {
            playBtn.onClick.AddListener(() => SceneController.Instance.ChangeScene("Gameplay"));
        }
    }
}
