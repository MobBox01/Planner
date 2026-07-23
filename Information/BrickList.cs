namespace Planner.Information;

public class BrickList
{
    ListNode<ScheduleBrick> start;

    public BrickList()
    {
        
    }
    

    private class ListNode<E>
    {
        private ListNode<E> pointer;
        private E data;

        public ListNode(ListNode<E> newNode)
        {
            if(newNode == null)
            {
                pointer = null;
            }
            else
            {
                pointer = newNode;
            }
        }

        public E Get()
        {
            return data;
        }

        public ListNode<E> GetNext()
        {
            return pointer;
        }

    }
}