using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void CategoryConstructor_CreatesInstanceOfCategory_Category()
        {
            Category newCategory = new Category("Test Cat");
            Assert.AreEqual(typeof(Category), newCategory.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Test Category";
            Category newCategory = new Category(name);
            string result = newCategory.GetName();
            Assert.AreEqual(name, result);
        }
    }
}