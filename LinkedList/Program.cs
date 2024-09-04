public class Node
{
    private int value;
    private Node next; // מצביע לצומת הבא מסוג צומת

    // בנאי שמקבל ערך ראשוני ומאתחל את הצומת
    public Node(int data)
    {
        value = data;
        next = null;
    }
    public int GetValue()
    {
        return value;
    }
    public Node GetNext()
    {
        return next;
    }

    public void SetValue(int data)
    {
        value = data;
    }

    public void SetNext(Node nextNode)
    {
        next = nextNode;
    }
}

public class LinkedList
{
    private Node head; // ראש הרשימה

    // בנאי ריק שיוצר רשימה ריקה
    public LinkedList()
    {
        head = null;
    }

    // בנאי שמקבל ערך ראשוני ומאתחל את הרשימה עם הצומת הראשון
    public LinkedList(int data)
    {
        head = new Node(data);
    }

    // פונקציה להוספת צומת לסוף הרשימה
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            // אם הרשימה ריקה, הצומת החדש הופך לראש
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            // הןספת הצומת החדש לסוף הרשימה
            current.SetNext(newNode);
        }
    }

    // פונקציה להצגת כל הצמתים ברשימה
    public string Display()
    {
        // בדיקה שיש ערכים ברשימה
        if (head == null)
        {
            return "The list is empty.";
        }

        // יצירת משתנה שיכיל את הצומת העכשווי
        Node current = head;

        string result = "";

        // לולאה לעבור על כל הרשימה
        while (current != null)
        {
            result += current.GetValue() + " -> ";
            current = current.GetNext();
        }

        return result.TrimEnd(' ', '-'); // מחזירים את הרשימה כמחרוזת
    }

    // פונקציה שמחזירה את האורך של הרשימה
    public int Length()
    {
        int length = 0;
        Node current = head;
        while (current != null)
        {
            length++;
            current = current.GetNext();
        }
        return length;
    }

    // פונקציה להסרת הצומת הראשון ברשימה עם ערך מסוים
    public void RemoveValue(int data)
    {
        // בדיקת המצאות ערכים ברשימה
        if (head == null) return;

        if (head.GetValue() == data)
        {
            // מדלגים על הצומת עם הוליו שרוצים למחוק
            head = head.GetNext();
            return;
        }

        Node current = head;
        while (current.GetNext() != null && current.GetNext().GetValue() != data)
        {
            current = current.GetNext();
        }

        if (current.GetNext() != null)
        {
            // מדלגים על הצומת עם הערך שרוצים למחוק
            current.SetNext(current.GetNext().GetNext());
        }
    }

    // פונקציה להסרת כל הצמתים עם ערך מסוים
    public void RemoveAllValues(int data)
    {
        while (head != null && head.GetValue() == data)
        {
            // מדלגים על הצומת עם הערך שרוצים למחוק
            // מעבירים מצביע
            head = head.GetNext();
        }

        Node current = head;
        while (current != null && current.GetNext() != null)
        {
            if (current.GetNext().GetValue() == data)
            {
                // מדלגים על הצומת עם הערך שרוצים למחוק
                current.SetNext(current.GetNext().GetNext());
            }
            else
            {
                current = current.GetNext();
            }
        }
    }

    // פונקציה להסרת צומת לפי אינדקס
    public void RemoveIndex(int index)
    {
        if (index < 0 || head == null) return;

        // אם זה אינדקס 0 
        if (index == 0)
        {
            // מעבירים את המצביע קדימה לצומת הבאה
            head = head.GetNext(); 
            return;
        }

        Node current = head;

        //  בדיקה אם האינדקס מחוץ לתחום
        for (int i = 0; i < index - 1; i++)
        {
            if (current.GetNext() == null) return;
            current = current.GetNext();
        }

        if (current.GetNext() != null)
        {
            // אני צריך לעבור שתיים קדימה כי אני משתמש באינדקס מינוס 1
            current.SetNext(current.GetNext().GetNext());
        }
    }

    // פונקציה למציאת אינדקס של צומת לפי ערך
    public int Find(int data)
    {
        int index = 0;
        Node current = head;
        while (current != null)
        {
            // בדיקה אם זה הערך
            if (current.GetValue() == data)
            {
                return index;
            }
            // אם לא, מעבירים לצומת הבאה
            current = current.GetNext();
            index++;
        }

        // מחזירים -1 אם הערך לא נמצא
        return -1; 
    }

    // פונקציה לקבלת ערך לפי אינדקס
    public int Get(int index)
    {
        if (index < 0)
        {
            return -1;
        }
        Node current = head;

        // אם האינדקס מחוץ לתחום
        for (int i = 0; i < index; i++)
        {
            // אם האינדקס לא קיים תחזיר -1
            if (current == null)
            {
                return -1;
            }
            // תעבור לצומת הבאה
            current = current.GetNext();
        }

        // בדיקה האם יש ערך
        //if(current/*.GetNext() != null*/)
        //{
            return current.GetValue();
       // }

        // אם אין, מחזירים -1
        return -1; 
    }
}


//class Program
//{
//    static void Main(string[] args)
//    {
//        // יצירת רשימה מקושרת חדשה והוספת ערכים
//        LinkedList list = new LinkedList();
//        list.Add(1);
//        list.Add(5);
//        list.Add(2);
//        list.Add(5);
//        list.Add(5);
//        list.Add(8);

//        // הצגת כל הערכים ברשימה
//        Console.WriteLine("print the link list:");
//        Console.WriteLine(list.Display());

//        // קבלת אורך הרשימה
//        Console.WriteLine("length list:");
//        Console.WriteLine(list.Length());

//        // הסרת הערך הראשון 5
//        list.RemoveValue(5);
//        Console.WriteLine("remove value:");
//        Console.WriteLine(list.Display());

//        // הסרת כל הערכים שהם 5
//        list.RemoveAllValues(5);
//        Console.WriteLine("removw all values:");
//        Console.WriteLine(list.Display());

//        // הוספת ערכים נוספים
//        list.Add(10);
//        list.Add(15);
//        list.Add(20);
//        Console.WriteLine("add values:");
//        Console.WriteLine(list.Display());

//        // הסרת ערך לפי אינדקס
//        list.RemoveIndex(2);
//        Console.WriteLine("remove index:");
//        Console.WriteLine(list.Display());

//        // חיפוש אינדקס לפי ערך
//        int index = list.Find(15);
//        Console.WriteLine("find by value:");
//        Console.WriteLine(index);

//        // קבלת ערך לפי אינדקס
//        int value = list.Get(2);
//        Console.WriteLine("the value in index 2:");
//        Console.WriteLine(value); 
//    }
//}



class Program
{
    static void Main(string[] args)
    {
        int totalTests = 0;
        int passedTests = 0;

        // Test 1: Creating an empty linked list
        totalTests++;
        try
        {
            LinkedList list1 = new LinkedList();
            if (list1.Length() == 0)
            {
                Console.WriteLine("Test 1 Passed: Creating an empty linked list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 1 Failed: Length is not zero for an empty list.");
            }
        }
        catch
        {
            Console.WriteLine("Test 1 Failed: Unexpected exception.");
        }

        // Test 2: Adding elements to the end of the list
        totalTests++;
        try
        {
            LinkedList list2 = new LinkedList();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            if (list2.Length() == 3 && list2.Display() == "1 -> 2 -> 3")
            {
                Console.WriteLine("Test 2 Passed: Adding elements to the end of the list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 2 Failed: Elements not added correctly.");
            }
        }
        catch
        {
            Console.WriteLine("Test 2 Failed: Unexpected exception.");
        }

        // Test 3: Removing a value (RemoveValue) from the list
        totalTests++;
        try
        {
            LinkedList list3 = new LinkedList();
            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.RemoveValue(2);

            if (list3.Length() == 2 && list3.Display() == "1 -> 3")
            {
                Console.WriteLine("Test 3 Passed: Removing a value from the list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 3 Failed: Value not removed correctly.");
            }
        }
        catch
        {
            Console.WriteLine("Test 3 Failed: Unexpected exception.");
        }

        // Test 4: Removing all instances of a value (RemoveAllValues)
        totalTests++;
        try
        {
            LinkedList list4 = new LinkedList();
            list4.Add(5);
            list4.Add(5);
            list4.Add(5);
            list4.RemoveAllValues(5);

            if (list4.Length() == 0 && list4.Display() == "")
                if (list4.Length() == 0 && list4.Display() == "")
                {
                    Console.WriteLine("Test 4 Passed: Removing all instances of a value from the list.");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine("Test 4 Failed: Not all instances of value removed.");
                }
        }
        catch
        {
            Console.WriteLine("Test 4 Failed: Unexpected exception.");
        }

        // Test 5: Removing by index (RemoveIndex)
        totalTests++;
        try
        {
            LinkedList list5 = new LinkedList();
            list5.Add(10);
            list5.Add(20);
            list5.Add(30);
            list5.RemoveIndex(1); // Should remove the second element

            if (list5.Length() == 2 && list5.Display() == "10 -> 30")
            {
                Console.WriteLine("Test 5 Passed: Removing by index.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 5 Failed: Value not removed at the correct index.");
            }
        }
        catch
        {
            Console.WriteLine("Test 5 Failed: Unexpected exception.");
        }

        // Test 6: Finding an element (Find) and getting the correct index
        totalTests++;
        try
        {
            LinkedList list6 = new LinkedList();
            list6.Add(100);
            list6.Add(200);
            int index = list6.Find(200);

            if (index == 1)
            {
                Console.WriteLine("Test 6 Passed: Finding an element returns the correct index.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 6 Failed: Incorrect index returned by Find method.");
            }
        }
        catch
        {
            Console.WriteLine("Test 6 Failed: Unexpected exception.");
        }

        // Test 7: Finding a non-existent element (Find)
        totalTests++;
        try
        {
            LinkedList list7 = new LinkedList();
            list7.Add(1);
            list7.Add(2);
            list7.Add(3);
            int index = list7.Find(4); // Element 4 does not exist

            if (index == -1) // Assuming -1 indicates not found
            {
                Console.WriteLine("Test 7 Passed: Finding a non-existent element returns -1.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 7 Failed: Incorrect result for finding a non-existent element.");
            }
        }
        catch
        {
            Console.WriteLine("Test 7 Failed: Unexpected exception.");
        }

        // Test 8: Getting a value by index (Get)
        totalTests++;
        try
        {
            LinkedList list8 = new LinkedList();
            list8.Add(101);
            list8.Add(102);
            int value = list8.Get(1);

            if (value == 102)
            {
                Console.WriteLine("Test 8 Passed: Getting a value by index.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 8 Failed: Incorrect value returned by Get method.");
            }
        }
        catch
        {
            Console.WriteLine("Test 8 Failed: Unexpected exception.");
        }

        // Test 9: Edge case - Removing from an empty list
        totalTests++;
        try
        {
            LinkedList list9 = new LinkedList();
            list9.RemoveValue(100); // Should handle gracefully without changes

            if (list9.Length() == 0)
            {
                Console.WriteLine("Test 9 Passed: Removing from an empty list does nothing.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 9 Failed: Removing from an empty list should not change length.");
            }
        }
        catch
        {
            Console.WriteLine("Test 9 Failed: Unexpected exception.");
        }

        // Test 10: Edge case - Getting from an empty list
        totalTests++;
        try
        {
            LinkedList list10 = new LinkedList();
            int value = list10.Get(0); // Should handle gracefully and return -1 or some error code

            if (value == -1) // Assuming -1 indicates an invalid index
            {
                Console.WriteLine("Test 10 Passed: Getting from an empty list returned -1.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 10 Failed: Incorrect value returned for empty list.");
            }
        }
        catch
        {
            Console.WriteLine("Test 10 Failed: Unexpected exception.");
        }

        // Test 11: Edge case - Index out of range
        totalTests++;
        try
        {
            LinkedList list11 = new LinkedList();
            list11.Add(1);
            int value = list11.Get(5); // Should handle gracefully and return -1 or some error code

            if (value == -1) // Assuming -1 indicates an invalid index
            {
                Console.WriteLine("Test 11 Passed: Out of range index correctly handled.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 11 Failed: Incorrect value returned for out of range index.");
            }
        }
        catch
        {
            Console.WriteLine("Test 11 Failed: Unexpected exception.");
        }

        // Test 12: Edge case - Removing the head of the list
        totalTests++;
        try
        {
            LinkedList list12 = new LinkedList();
            list12.Add(10);
            list12.Add(20);
            list12.RemoveValue(10); // Remove the head element

            if (list12.Length() == 1 && list12.Display() == "20")
            {
                Console.WriteLine("Test 12 Passed: Removing the head of the list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 12 Failed: Head not removed correctly.");
            }
        }
        catch
        {
            Console.WriteLine("Test 12 Failed: Unexpected exception.");
        }

        // Test 13: Edge case - Large data set
        totalTests++;
        try
        {
            LinkedList list13 = new LinkedList();
            for (int i = 0; i < 1000; i++)
            {
                list13.Add(i);
            }

            bool correctLength = list13.Length() == 1000;
            bool correctValue = list13.Get(999) == 999;

            if (correctLength && correctValue)
            {
                Console.WriteLine("Test 13 Passed: Handling a large data set.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 13 Failed: Incorrect behavior with a large data set.");
            }
        }
        catch
        {
            Console.WriteLine("Test 13 Failed: Unexpected exception.");
        }

        // Final Test Summary
        Console.WriteLine("\nFinal Test Summary: " + passedTests + " out of " + totalTests + " tests passed.");



    }
}
