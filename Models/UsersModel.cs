using Newtonsoft.Json;

public class UsersModel
{
    private readonly string pathToFile = @".\wwwroot\db\users.json";
    public List<User> listusers;

    // public void AddUser(string name, string surname,string gender, int age,string email)
    // {
    //     listusers.Add(new User(name,surname,gender,age,email));
    // }

    public UsersModel()
    {
        DeserializeList();
    }

    public void AddUser(User user)
    {
        listusers.Add(user);
        SerializeList();
    }

    private void SerializeList()
    {
        string json = JsonConvert.SerializeObject(listusers);
        File.WriteAllText(pathToFile, json);
    }

    private void DeserializeList()
    {
        string json = ReadFileToString();
        listusers = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
    }

    private string ReadFileToString()
    {
        if (!File.Exists(pathToFile))
        {
            File.WriteAllText(pathToFile, "");
        }

        return File.ReadAllText(pathToFile);
    }
}