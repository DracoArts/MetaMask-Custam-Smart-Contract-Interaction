
![Logo](https://dracoarts-logo.s3.eu-north-1.amazonaws.com/DracoArts.png)


# MetaMask Custam Smart Contract Interaction:

The "Custom Smart Contract Interaction with MetaMask" project serves as a versatile tool for users interested in engaging with smart contracts on different blockchain networks compatible with MetaMask. Here's a more detailed explanation:

# Flexibility: 
This project accommodates users looking to interact with a diverse range of smart contracts, not limited to a specific blockchain like Ethereum. It allows users to connect their MetaMask wallets to various blockchain networks that MetaMask supports.
# Accessibility: 
By providing a user-friendly interface, the project ensures that individuals, regardless of their level of expertise, can easily connect their MetaMask wallets, add custom smart contracts, and interact with the functions of these contracts.
Security: MetaMask ensures secure transactions by prompting users to confirm each interaction with a smart contract. This helps prevent unauthorized access and ensures that users have control over their digital assets.
# Efficiency: 
The project streamlines the process of interacting with smart contracts, making it quick and convenient for users to send transactions, call functions, and view contract data without the need for complex technical knowledge.
# Versatility: 
Users can leverage the capabilities of MetaMask to engage with a wide array of decentralized applications and smart contracts, enabling them to participate in various blockchain ecosystems effectively.
Overall, the "Custom Smart Contract Interaction with MetaMask" project empowers users to explore and engage with smart contracts across different blockchain networks, providing a seamless and secure experience for decentralized application interaction
# Contract Interaction: 
 The script facilitates interactions with a custom smart contract on a blockchain network.
# Contract Address and ABI: 
It includes fields to specify the contract address and ABI (Application Binary Interface) for the target smart contract.
# RPC Endpoint: 
Defines the RPC (Remote Procedure Call) endpoint for connecting to the blockchain network.
Wallet Address: User's wallet address can be set for transaction authorization.
SendTransaction Function: Demonstrates how to send a transaction to the smart contract.
# Transaction Status Check: 
Monitors the transaction status to determine success or failure.
Instructions:
# Setup: 
Ensure the required libraries and dependencies are included in your Unity project.
Update the contract address, ABI, RPC endpoint, and wallet address as needed for your specific smart contract and blockchain network.
 # Interact with Contract:
 Use the provided functions to interact with the custom smart contract.
# Transaction Handling: 
 Check the transaction status to confirm the outcome of the transaction.


## Usage/Examples

    public string rPC = "https://rpc2-testnet.icbnetwork.info";
    [SerializeField]
    private string walletAddress;
    double amount;
    [SerializeField]
    private string contractAddress = "";
    private string contractAbi = []
    private void Start()
    {
        walletAddress = PlayerPrefs.GetString("Account");
       
    }
    async public void OnSendContract()
    {
        BigInteger decimals = BigInteger.Pow(10, 18);
        BigInteger balanceERC20 = BigInteger.Divide(BigInteger.Multiply(new BigInteger(amount), decimals), BigInteger.One);
        string amount1 = balanceERC20.ToString();
        string method = "transferTokens";
        string[] obj = { amount1 };
        string args = JsonConvert.SerializeObject(obj);
        string value = "0";
        string gasLimit = "";
        string gasPrice = "";

        try
        {
            string response = await Web3GL.SendContract(method, contractAbi,    contractAddress, args, value, gasLimit, gasPrice);
            Debug.Log(response);

            //    Transaction Status;
            var provider = new JsonRpcProvider(rPC);
            var Transaction = await provider.GetTransactionReceipt(response.ToString());

            while (Transaction.Status == null)
            {
                await new WaitForSeconds(1f);
                Debug.Log("Waiting For TX Status");
                var TransactionRecheck = await RPC.GetInstance.Provider().GetTransactionReceipt(response.ToString());
                Transaction = TransactionRecheck;
            }

            Debug.Log("Transaction Code: " + Transaction.Status);

            if (Transaction.Status.ToString() == "0")
            {
                Debug.Log("Transaction has been failed");
            }
            else if (Transaction.Status.ToString() == "1")
            {

                Debug.Log("Transaction has been successful");
            }
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }


## Image
![Logo](https://dracoarts-logo.s3.eu-north-1.amazonaws.com/ContractAddress-min.png)
## Authors

- [@DracoArts](https://github.com/orgs/DracoArts)

 -


## Demo

https://draco-arts.itch.io/custom-smart-contract

## 🔗 Links

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/company/mir-hamza-hasan/posts/?feedView=all/)
## Tech Stack
**Client:** Unity,C#

**Server:** Web3,

