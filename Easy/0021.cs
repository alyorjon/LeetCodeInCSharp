namespace LeetCodeInCSharp.Easy
{
    // ListNode klassi ta'rifi
    public class ListNode 
    {
        public int val;           // Tugunning qiymati
        public ListNode next;     // Keyingi tugunning manzili
        
        // Konstruktorlar
        public ListNode(int val = 0, ListNode next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }
}