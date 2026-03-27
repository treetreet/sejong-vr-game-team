using UnityEngine;
using Fusion;
using System.Threading.Tasks;

public class FusionLobbyLauncher : MonoBehaviour
{
    private NetworkRunner _runner;

    public async void ConnectToLobby()
    {
        if (_runner == null)
        {
            _runner = gameObject.GetComponent<NetworkRunner>();
        }

        var result = await _runner.JoinSessionLobby(SessionLobby.ClientServer);

        if (result.Ok)
            Debug.Log("Success To Connect Lobby.");
        else
            Debug.LogError($"Failed To Connect Lobby : {result.ShutdownReason}");
    }
}
