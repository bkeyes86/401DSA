namespace DataStructures.LinkedList
{
    public class LinkedLister
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            Node newNode = new Node(value);

            newNode.Next = Head;

            Head = newNode;
        }

        public bool Includes(int value)
        {
            Node current = Head;
            int input = value;

            while (current != null)
            {
                if (current.Value == input)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public override string ToString()
        {
            Node current = Head;
            string result = "";

            while (current != null)
            {
                result += $"{{ {current.Value} }} -> ";
                current = current.Next;
            }
            return result + "NULL";
        }

        public void Append(int value)
        {
            Node node = new Node(value);
            Node current = Head;

            if (current == null)
            {
                Head = node;
                return;
            }

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }
    }
}