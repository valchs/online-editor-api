using OnlineEditor.Models.Files;

namespace OnlineEditor.Repository;

public static class MockDatabase
{
    public static List<FileModel> Files = new List<FileModel>
    {
        new FileModel
        {
            Name = "test1.json",
            Data = @"
            {
              ""id"": 1,
              ""name"": ""Jon"",
              ""email"": ""jon@example.com""
            }",
        },
        new FileModel
        {
            Name = "test2.json",
            Data = @"
            {
              ""id"": 2,
              ""name"": ""Dave"",
              ""email"": ""dave@example.com""
            }",
        },
        new FileModel
        {
            Name = "test3.json",
            Data = @"
            {
              ""id"": 3,
              ""name"": ""Emily"",
              ""email"": ""emily@example.com""
            }",
        },
    };
}
