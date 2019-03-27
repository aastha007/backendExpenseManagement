using expenseManagementBackend.Controllers;
using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Data_Manager;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestingExpenseManagement
{
    public class UnitTest1
    {
        ValuesController _controller;
        private readonly IDataRepository<user> _service;
       

        public UnitTest1()
        {
            _service = new UserFake();
            _controller = new ValuesController(_service);
        }
        [Fact]
        public void Test1()
        {
            var okResult = _controller.Get();

            Assert.IsType<OkObjectResult>(okResult);

            var objectResponse = okResult as ObjectResult;

            Assert.Equal(200, objectResponse.StatusCode);

        }
        [Fact]
        public void Test2()
        {
            var okResult = _controller.Get(1);
            Assert.IsType<OkObjectResult>(okResult);


            var objectResponse = okResult as ObjectResult;

            Assert.Equal(200, objectResponse.StatusCode);
        }
       
    }
}
