using System;
using Xunit;
using StoreModels;
using StoreDL;
using Microsoft.EntityFrameworkCore;

namespace StoreTest
{
    public class UnitTest1
    {
        private readonly DbContextOptions<StoreDBContext> options;
        /*private Project inv = new Project();
        [Theory]
        [InlineData (0, true)]
        [InlineData(-2, false)]
        public void CheckQuantity(int q, bool expected)
        {
            bool result = inv.CheckQuantity(q);
            Assert.Equal(result, expected);
        }
        */
    }
}