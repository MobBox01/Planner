namespace Planner.Information;

public class BrickList
{
    ListNode<ScheduleBrick> start;

    public BrickList()
    {

    }
    public void RemoveBrick(int index)//Button object here
    {
        //If Brick's variable address IS equal to button object, return true
    }
    //Each brick will know its index # 
    

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

        public E GetData()
        {
            return data;
        }

        public ListNode<E> GetNext()
        {
            return pointer;
        }

        public void Set(ListNode<E> newNode)
        {
            pointer = newNode;
        }
    }
}