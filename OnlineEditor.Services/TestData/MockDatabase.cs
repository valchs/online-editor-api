using OnlineEditor.Models.Files;

namespace OnlineEditor.Services.TestData;

public static class MockDatabase
{
    // In real world I would load this data from persistent data storage
    public static List<FileModel> Files = new List<FileModel>
    {
        new FileModel 
        { 
            Name = "test1", 
            Data = @"
            {
              ""id"": 1,
              ""name"": ""Emily Jones"",
              ""email"": ""emilyjones@example.com""
            }",
        },
        new FileModel
        {
            Name = "test2",
            Data = @"
            {
              ""id"": 2,
              ""name"": ""Emily Jones"",
              ""email"": ""emilyjones@example.com""
            }",
        },
        new FileModel
        {
            Name = "test3",
            Data = @"
            {
              ""id"": 3,
              ""name"": ""Emily Jones"",
              ""email"": ""emilyjones@example.com""
            }",
        },
    };
}
