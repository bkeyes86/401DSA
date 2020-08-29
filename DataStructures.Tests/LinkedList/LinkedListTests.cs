using System;
using Xunit;
using DataStructures.LinkedList;


namespace DataStructures.Tests.LinkedList
{
    public class LinkedListTests
    {
        [Fact]
        public void LinkedListTest_starts_empty()
        {
            //Act
            LinkedLister list = new LinkedLister();

            //Assert
            Assert.Equal("NULL", list.ToString());
        }

        [Fact]
        public void Insert_adds_value_to_start()
        {
            //Arrange
            LinkedLister list = new LinkedLister();

            //Act
            list.Insert(1);

            //Assert
            Assert.Equal("{ 1 } -> NULL", list.ToString());

            //Act
            list.Insert(2);

            //Assert
            Assert.Equal("{ 2 } -> { 1 } -> NULL", list.ToString());

        }

        [Fact]
        public void Includes_finds_input_in_list()
        {
            //Arrange
            LinkedLister list = new LinkedLister();

            //Act 
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);

            //Assert
            bool expected = false;
            Assert.Equal(list.Includes(4), expected);

        }

    }

}
