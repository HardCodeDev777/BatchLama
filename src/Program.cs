using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HardCodeDev.BatchLama
{
    public class Program
    {
        private static List<ChatMessage> _chatHistory = new();
        private static IChatClient _chatClient;
        private static string _modelName, _systemPrompt, _userPrompt;

        // Example: "deepseek-r1:7b, your answer mustn't be more than 50 words, When Github was created?"
        public static async Task Main(string[] args)
        {
            var input = args[0];
            var words = input.Split(',');
            try
            {
                _modelName = words[0];
                _systemPrompt = words[1];
                _userPrompt = words[2];
            }
            catch
            {
                Console.WriteLine("Incorrect syntax or amount of arguments!");
                return;
            }
            await InitOllama();
            var response = await SendMessage();
            Console.WriteLine($"AI response: {response}");
            return;
        }

        private static async Task InitOllama()
        {
            var builder = Host.CreateApplicationBuilder(new HostApplicationBuilderSettings
            { DisableDefaults = true });

            builder.Services.AddChatClient(new OllamaChatClient(new Uri("http://localhost:11434"), _modelName));

            _chatClient = builder.Build().Services.GetRequiredService<IChatClient>();

            _chatHistory.Add(new(ChatRole.System, _systemPrompt));
        }

        public static async Task<string> SendMessage()
        {
            _chatHistory.Add(new(ChatRole.User, _userPrompt));

            var chatResponse = "";
            await foreach (var item in _chatClient.GetStreamingResponseAsync(_chatHistory)) chatResponse += item.Text;

            _chatHistory.Add(new(ChatRole.Assistant, chatResponse));
            return chatResponse;
        }
    }
}