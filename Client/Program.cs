// See https://aka.ms/new-console-template for more information

using System.Text;

using var httpClient = new HttpClient();
var serverUrl = "http://localhost:5001/api/Log/Post";
Console.WriteLine("Enter data to send to the server (type 'exit' to quit):");

while (true)
{
    Console.Write("> ");
    var input = Console.ReadLine();

    if (input?.ToLower() == "exit")
        break;

    var content = new StringContent($"{{\"Log\":\"{input}\"}}", Encoding.UTF8, "application/json");


    try
    {
        var response = await httpClient.PostAsync(serverUrl, content);
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Data sent successfully.");
        }
        else
        {
            Console.WriteLine($"Failed to send data. Status code: {response.StatusCode}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}