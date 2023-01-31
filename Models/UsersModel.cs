using Newtonsoft.Json;

public class UsersModel
{
    private readonly string pathToFile = "~/wwwroot/db/users.json";
    public List<User> listusers = new List<User>();

    // public void AddUser(string name, string surname,string gender, int age,string email)
    // {
    //     listusers.Add(new User(name,surname,gender,age,email));
    // }

    public void AddUser(User user)
    {
        
        listusers.Add(user);
    }

    private void SerializeList()
    {
        string json = JsonConvert.SerializeObject(listusers);
    }

    private void DeserializeList()
    {
        string json = "";
        listusers = JsonConvert.DeserializeObject<List<User>>(json);
    }
}