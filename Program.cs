using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonSourceGeneratorWIthoutReflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new() { Id = 1, Name = "Nishikori Kei" };
            string json = JsonSerializer.Serialize(player, JsonContext.Default.Player);
            Console.WriteLine(json);
        }
    }

    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [JsonSerializable(typeof(Player), GenerationMode = JsonSourceGenerationMode.MetadataAndSerialization)]
    internal partial class JsonContext : JsonSerializerContext { }
}