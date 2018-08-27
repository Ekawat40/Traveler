using Firebase.Auth;
using Google;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class login :MonoBehaviour {
    public Text responseText;
    public Button loginGoogleButton;
    string accessToken = "ya29.Glu5BcaOHbiudAne7RX3qNb9Q_-SSRH3nqS97fQK-YnIbFdDyjtWn-i9BQROgUDCInsxMaRb8D_8GN7OvEslgnOxkz7LE9bED8t0PXMiWrnco6L2B4KzoE5Oetv1";
    string idToken;
    Firebase.Auth.Credential credentials;
    void loginGoogle()
    {
        GoogleSignIn.Configuration = new GoogleSignInConfiguration
        {
            RequestIdToken = true,
            // Copy this value from the google-service.json file.
            // oauth_client with type == 3
            WebClientId = "748713475123-n8h56hc5r3pf10a14a5n6122c20b5q0u.apps.googleusercontent.com"
        };

         Task<GoogleSignInUser> signIn = GoogleSignIn.DefaultInstance.SignIn();

        TaskCompletionSource<FirebaseUser> signInCompleted = new TaskCompletionSource<FirebaseUser>();
        signIn.ContinueWith(task => {
            if (task.IsCanceled)
            {
                signInCompleted.SetCanceled();
            }
            else if (task.IsFaulted)
            {
                signInCompleted.SetException(task.Exception);
            }
            else
            {
                FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
                Credential credential = Firebase.Auth.GoogleAuthProvider.GetCredential(((Task<GoogleSignInUser>)task).Result.IdToken, null);
                auth.SignInWithCredentialAsync(credential).ContinueWith(authTask => {
                    if (authTask.IsCanceled)
                    {
                        signInCompleted.SetCanceled();
                    }
                    else if (authTask.IsFaulted)
                    {
                        signInCompleted.SetException(authTask.Exception);
                    }
                    else
                    {
                        signInCompleted.SetResult(((Task<FirebaseUser>)authTask).Result);
                    }
                });
            }
        });
        //Social.localUser.Authenticate((bool success) => {
            // handle success or failure
        /*});
        FirebaseAuth auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        credentials = Firebase.Auth.GoogleAuthProvider.GetCredential(idToken, accessToken);
        auth.SignInWithCredentialAsync(credentials).ContinueWith(task =>
        {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithCredentialAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithCredentialAsync encountered an error: " + task.Exception);
                return;
            }
            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
            
        });*/

    }
	// Use this for initialization
	void Start () {
        loginGoogleButton.onClick.AddListener(loginGoogle);
	}
    GooglePlayGames.TokenClient token;
	// Update is called once per frame
	void Update () {
        
	}
}
