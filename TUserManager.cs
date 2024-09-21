using Users;

namespace UserTesting
{
    [TestClass]
    public class TUserManager
    {
        
        [TestMethod]
        public void TestWrite()
        {
    
            UserManager userManager = new UserManager();
            List<User> expectedUsers = new List<User>() { new User() {Login = "abc", Password = "123", Name = "Vasya" },
                                                  new User() {Login = "cbd", Password = "1234", Name = "Petya" }};

            bool success = userManager.Write(expectedUsers);
            Assert.IsTrue(success);

            List<User> actualUsers = userManager.ReadAll();
            CollectionAssert.AreEqual(expectedUsers, actualUsers);
        }
    }
}