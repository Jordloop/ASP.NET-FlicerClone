using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FlickrClone.Controllers;
using FlickrClone.Models;
using Xunit;
using Microsoft.AspNetCore.Identity;

namespace FlickrCloneTests.Tests.ControllerTests
{
    public class AccountControllerTests
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
