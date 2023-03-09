// HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
using OpenAI_ConsoleApp;
using OpenAI_HttpClient;
using System.Net.Http;
using System.Net.Http.Json;

try
{
    Console.WriteLine("¡Pregúntame algo!");
    var question = Console.ReadLine();
    var responseBody = await Http_Client.Post(question);
    Console.WriteLine($"Chat GPT: {responseBody?.Response ?? "Respuesta no disponible"}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ha ocurrido una excepción no esperada. Error: {ex.Message}");
}