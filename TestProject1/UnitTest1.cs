using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_BtnSave_Click()
        {
            // Arrange
            var mockContext = new Mock<PhotooStudiiioooEntities2>();
            var mockUserDbSet = new Mock<DbSet<User>>();

            mockContext.Setup(c => c.User).Returns(mockUserDbSet.Object);

            // ������� ��������� ������ ������ � �������� � ���� mock-��������
            var yourClassInstance = new YourClass(mockContext.Object);

            // Act
            yourClassInstance.BtnSave_Click(null, null);

            // Assert
            // ���������, ��� ����� SaveChanges ��� ������ � mock-���������
            mockContext.Verify(c => c.SaveChanges(), Times.Once);
        }
    }
}
