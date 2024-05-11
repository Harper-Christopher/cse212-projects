//https://stackoverflow.com/questions/63361473/deserialize-json-usgs-earthquake-catalog-api
using System.Text.Json.Serialization;

public class FeatureCollection {
    public Feature[] Features {get; set;}
}