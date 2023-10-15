using System.Text.Json;
using System.Text.Json.Serialization;

namespace RPC.Model;

public class CommandBaseConverter : JsonConverter<CommandBase>
{
    // TODO [AboimPinto]: Need to inject the strategies to Read and deserialize correctly

    public override CommandBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // TODO: all this logic will be replaces by the ISpecificTransactionDeserliazer

        using (var jsonDocument = JsonDocument.ParseValue(ref reader))
        {
            var element = jsonDocument.RootElement;
            var command = element.GetProperty("Command").GetString();

            if (command == "HandshakeCommand")
            {
                return JsonSerializer.Deserialize<HandshakeCommand>(element.GetRawText());
            }
        }

        throw new InvalidOperationException();
    }

    public override void Write(Utf8JsonWriter writer, CommandBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}