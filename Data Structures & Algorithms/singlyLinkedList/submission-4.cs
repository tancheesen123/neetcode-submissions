public class LinkedList {

    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode(int val) {
            this.val = val;
        }
    }

    private ListNode head;
    private ListNode tail;

    public LinkedList() {
        head = null;
        tail = null;
    }

    public int Get(int index) {
        ListNode cur = head;
        int i = 0;
        while (cur != null) {
            if (i == index) {
                return cur.val;
            }
            cur = cur.next;
            i++;
        }
        return -1;
    }

    public void InsertHead(int val) {
        ListNode newNode = new ListNode(val);

        if (head == null) {
            head = newNode;
            tail = newNode;
            return;
        }

        newNode.next = head;
        head = newNode;
    }

    public void InsertTail(int val) {
        ListNode newNode = new ListNode(val);

        if (tail == null) {
            head = newNode;
            tail = newNode;
            return;
        }

        tail.next = newNode;
        tail = newNode;
    }

    public bool Remove(int index) {
        if (index < 0 || head == null) {
            return false;
        }

        if (index == 0) {
            head = head.next;
            if (head == null) {
                tail = null;
            }
            return true;
        }

        ListNode prev = head;
        for (int i = 0; i < index - 1; i++) {
            if (prev == null) {
                return false;
            }
            prev = prev.next;
        }

        if (prev == null || prev.next == null) {
            return false;
        }

        prev.next = prev.next.next;
        if (prev.next == null) {
            tail = prev;
        }

        return true;
    }

    public List<int> GetValues() {
        List<int> result = new List<int>();
        ListNode cur = head;
        while (cur != null) {
            result.Add(cur.val);
            cur = cur.next;
        }
        return result;
    }
}