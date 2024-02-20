using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class StudTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.SName = "Aarav";

            // Act
            string studentName = student.SName;

            // Assert
            Assert.AreEqual("Aarav", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "45 Lal Street";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("45 Lal Street", studentAddress);
        }
    }
}
