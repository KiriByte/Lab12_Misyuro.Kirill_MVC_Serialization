public class User
{
    public string name { get; set; }
    public string surname { get; set; }
    public string gender { get; set; }
    public int age { get; set; }

    public string email { get; set; }

    public User()
    {
    }

    public User(string name, string surname, string gender, int age, string email)
    {
        this.name = name;
        this.surname = surname;
        this.gender = gender;
        this.age = age;
        this.email = email;
    }
}