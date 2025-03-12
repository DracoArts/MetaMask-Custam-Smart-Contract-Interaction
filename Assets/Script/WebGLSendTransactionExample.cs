using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_WEBGL
public class WebGLSendTransactionExample : MonoBehaviour
{
    async public void OnSendTransaction()
    {
        // account to send to
        string to = "0x23EC08c1fE036935EC49666ba5E7c05252f04f93";
        // amount in wei to send
        string value = "12300000000000000";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try
        {
            string response = await Web3GL.SendTransaction(to, value, gasLimit, gasPrice);
            Debug.Log(response);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }
}
#endif