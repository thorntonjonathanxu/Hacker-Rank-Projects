    /*
      Insert Node at the end of a linked list
      head pointer input could be NULL as well for empty list
      Node is defined as
      class Node {
         int Data;
         Node Next;
      }
    */
    // This is a "method-only" submission.
    // You only need to complete this method.

    public static Node Insert(Node head, int x)
    {        
        if(head == null)
        {
            head = new Node();
            head.Data = x;
        }
        else
        {
            Node newNode = head;
            while(newNode.Next != null)
            {
                newNode = newNode.Next;
            }
            newNode.Next = new Node();
            newNode.Next.Data = x;
        }
        return head;
        
    }
