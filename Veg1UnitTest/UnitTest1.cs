using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using veg1.Controllers;
using System.Linq;
using veg1.Models;

namespace Veg1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingAddMethod()
        {
            // Arrange
            var sut = new RecipesController();

            // Act
            int something = sut.add(3,4);

            // Assert
            Assert.AreEqual(something, 7);
        }

        [TestMethod]
        public void TesingRecipeCount()
        {
            // Arrange
            var sut = new RecipesController();

            // Act
            IQueryable<Recipe> recipes = sut.GetRecipes("Apple");

            // Assert
            Assert.AreEqual(recipes.Count(), 45);
        }
    }
}
