namespace GeekBrainsTests
{
    public class Node : ILinkedList
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }

        public void AddNode(int value)
        {
            throw new System.NotImplementedException();
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new System.NotImplementedException();
        }

        public Node FindNode(int searchValue)
        {
            throw new System.NotImplementedException();
        }

        public int GetCount()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveNode(int index)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new System.NotImplementedException();
        }
    }

    //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value);  // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

}
