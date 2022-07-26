﻿namespace Devil_Awakening_Bot.Helper;

public class JsonHelper<T> where T : new()
{
    private const string DefaultFilename = "settings.json";

    public void Save(string fileName = DefaultFilename)
    {
        File.WriteAllText(fileName, JsonConvert.SerializeObject(this, Formatting.Indented));
    }

    public static T Load(string fileName = DefaultFilename)
    {
        var t = new T();
        if (File.Exists(fileName))
        {
            try
            {
                t = JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
            }
            catch
            {
                return t!;
            }
        }
        return t!;
    }
}