/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prevNode = null;
        return f(head, prevNode);
    }
    ListNode f(ListNode head, ListNode prevNode){
        if(head is null) return prevNode;
        var temp = head.next;
        head.next = prevNode;
        prevNode = head;
        head = temp;
        return f(head, prevNode);
    }
}
