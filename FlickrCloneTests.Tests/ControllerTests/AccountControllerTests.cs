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
        //Test Accont Index View
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

        //Test Accont Login View
        [Fact]
        public void Get_ViewResult_Login_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Login();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        //Test Accont Register View
        [Fact]
        public void Get_ViewResult_Register_Test()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            var result = controller.Register();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

    }
}
