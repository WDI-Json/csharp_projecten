using System;
using System.Text.Json;
using System.Text.Json.Serialization;

/*
The string converter is a custom JSON converter used in the sendRequest<T>() method of the http service to deserialize numbers as strings from API responses.

This makes the Blazor app compatible with APIs that return either integer id or string id properties in JSON responses. Without the string converter, 
an API that returns an int id results in the error: The JSON value could not be converted to System.String. Path: $.id.
*/
namespace KnutselenBlazor.Helpers
{
    public class StringConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // deserialize numbers as strings.
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetInt32().ToString();
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                return reader.GetString();
            }
 
            throw new System.Text.Json.JsonException();
        }
 
        public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value);
        }
    }
}