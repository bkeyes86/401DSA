using DataStructures.LinkedList;
using Xunit;

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

        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, true)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        public void Includes_finds_input_in_list(int valueToFind, bool expected)
        {
            //Arrange
            LinkedLister list = new LinkedLister();

            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);
            list.Insert(5);

            //Act
            bool result = list.Includes(valueToFind);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Insert_new_node_in_empty_list()
        {
            // Arrange
            LinkedLister list = new LinkedLister();

            // Act
            list.Append(3);

            // Assert
            Assert.Equal("{ 3 } -> NULL", list.ToString());
        }

        [Fact]
        public void Insert_new_node_in_list()
        {
            // Arrange
            LinkedLister list = new LinkedLister();

            list.Insert(5);
            list.Insert(6);

            // Act
            list.Append(3);

            // Assert
            Assert.Equal("{ 6 } -> { 5 } -> { 3 } -> NULL", list.ToString());
        }
    }
}