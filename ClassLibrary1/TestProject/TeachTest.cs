using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class TeachTest
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherId = 201;
            teacher.Name = "Mrs. Lalitha";

            // Act & Assert
            Assert.AreEqual(201, teacher.TeacherId);
            Assert.AreEqual("Mrs. Lalitha", teacher.Name);
        }
    }
}
