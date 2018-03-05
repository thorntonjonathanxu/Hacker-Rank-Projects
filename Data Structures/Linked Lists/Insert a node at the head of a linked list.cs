/* Completed 3/4/2018


    Insert Node at the beginning of a linked list
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
        Node newNode = new Node();
        newNode.Data = x;
        newNode.Next = head;
        return newNode;
        
    }

