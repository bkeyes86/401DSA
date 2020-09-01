using System;
using Xunit;
using DataStructures.LinkedList;
using System.Transactions;
using System.Collections.Generic;

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

            //Act
            list.Insert(3);

            //Assert
            Assert.Equal("{ 3 } -> { 2 } -> { 1 } -> NULL", list.ToString());
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
            Assert.Equal(expected, list.Includes(4));
        }

        [Fact]
        public void Insert_new_node_in_list()
        {
            LinkedLister list = new LinkedLister();

            list.Insert(5);
            list.Insert(6);
            list.Insert(8);
            list.Insert(9);

            list.Append(3);

            Assert.Equal("Hello", list.ToString());

        }

    }

}
