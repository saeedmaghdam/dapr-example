// See https://aka.ms/new-console-template for more information
using Dapr.Client;

const string storeName = "statestore";
const string key = "counter";

Console.WriteLine($"Process started ...");

var daprClient = new DaprClientBuilder().Build();
await daprClient.WaitForSidecarAsync();
var counter = await daprClient.GetStateAsync<int>(storeName, key);

while (true)
{
    Console.WriteLine($"Counter = {counter++}");

    await daprClient.SaveStateAsync(storeName, key, counter);
    await Task.Delay(1000);
}