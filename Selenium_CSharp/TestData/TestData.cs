
namespace Selenium_CSharp{

    public static class TestData
    {
        public static class Users
        {
            public static readonly string User1Username = "user1";
            public static readonly string User1Password = "password1";
            public static readonly string User1Role = "admin";
            public static readonly Dictionary<string, string> User1AdditionalData = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };

            public static readonly string User2Username = "user2";
            public static readonly string User2Password = "password2";
            public static readonly string User2Role = "manager";
            public static readonly Dictionary<string, string> User2AdditionalData = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" }
            };
        }
    }
}