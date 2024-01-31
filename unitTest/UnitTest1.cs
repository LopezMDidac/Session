using Microsoft.VisualStudio.TestPlatform.TestHost;
using Session;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestListAllUsersEmpty()
        {
            var users = new List<User>();
            
            var listed = Session.Program.ListUsers(users);

            Assert.IsNotNull(listed);
            Assert.IsFalse(listed.Any());
        }

        [TestMethod]
        public void TestListAllUsersMultipleUsers()
        {
            var users = new List<User>();
            users.Add(new User("IronMan", 40, true));
            users.Add(new User("Thanos", 400, false));
            users.Add(new User("BlackWidow", 30, true));

            var listed = Session.Program.ListUsers(users);

            Assert.IsNotNull(listed);
            Assert.AreEqual(3, listed.Count);
        }
        [TestMethod]
        public void TestListInternalUsersMultipleUsers()
        {
            var users = new List<User>();
            users.Add(new User("IronMan", 40, true));
            users.Add(new User("Thanos", 400, false));
            users.Add(new User("BlackWidow", 30, true));

            var listed = Session.Program.ListUsers(users, true, false);

            Assert.IsNotNull(listed);
            Assert.AreEqual(2, listed.Count);
        }

        [TestMethod]
        public void TestListExternalUsersMultipleUsers()
        {
            var users = new List<User>();
            users.Add(new User("IronMan", 40, true));
            users.Add(new User("Thanos", 400, false));
            users.Add(new User("BlackWidow", 30, true));

            var listed = Session.Program.ListUsers(users, false, true);

            Assert.IsNotNull(listed);
            Assert.AreEqual(1, listed.Count);
        }
    }
}