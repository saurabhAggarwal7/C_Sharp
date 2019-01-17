using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Person Class:
        Person obj = new Person(1, "name");
        List<Person> listObject = new List<Person>();
        listObject.Add(new Person(2, "name2"));

        //Tree Class:
        BinaryTree tree = new BinaryTree();
        //print_Tree(tree);

        //Type-1---> Get Input from user in the form of array and it's size:
        //number of times input taken as per this integer variable:

        /*Console.WriteLine("\nEnter the size of the input");
        int inputSize = Convert.ToInt32(Console.ReadLine());

        //no of times input will be taken
        for (var i = 0; i < inputSize; i++)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            var result = method_1(s1, s2);
            Console.WriteLine(result);
        }
        Console.Out.Flush();
        Console.Out.Close();
        //2
        //one//two//three//four
        //Result //YES//NO
         */

        //Type:2--> only show output on screen:
        method_1("abc", "def");
        Console.ReadLine();
        Console.Out.Flush();
        Console.Out.Close();


    }

    public static string method_1(string s1, string s2)
    {
        //ref: https://www.dotnetperls.com/arraylist

        //array 
        string[] array_01 = new string[50];
        //you cannot simply add new value to array like push

        //string array
        string[] array_02 = new string[] { "hi", "there", "hey" };

        //int array
        int[] array_03 = new int[] { 1, 2, 3 };

        //Create a list first for push and pop and then convert to array
        List<int> list_01 = new List<int>();
        list_01.Add(1);
        list_01.Add(2);
        list_01.Remove(1);
        //list_01.RemoveAt(1);

        //List To array with Push
        var list_01_array = list_01.ToArray();

        //array to List:
        //list_01.ToList();

        //string to array
        string test1 = "hi there";
        string[] array_04 = new string[] { test1 };

        //string to character array
        char[] char_1 = s1.ToCharArray();
        for (int i = 0; i < char_1.Length; i++)
        {
            char indiviual_Char = char_1[i];
        }

        //Array Operations
        list_01_array.Average(); //min//max //sum //
        list_01_array.Contains(1); //distinct //except //firstOrDefault //First() 

        //Count()
        array_03.Count();

        //value of the element at index 0
        list_01_array.ElementAt(0);

        //check for equality of arrays
        bool isEqual = list_01_array.Equals(array_03);

        //array length
        int len = array_03.Length;

        //order by descending/ascending
        array_03.OrderByDescending(a => a);

        //reverse an array
        array_03.Reverse();

        //except//intersect//unioun //Any() gives bool for existenece
        array_03.Where(a => a > 0);
        array_03.Select(a => a > 0);
        array_03.GroupBy(a => a);

        //List:
        List<int> list_02 = new List<int>() { 1, 2, 3 };
        List<int> list_duplicate_elem = new List<int>() { 1, 2, 3, 1, 1 };

        //Print a list
        list_02.ForEach(a => Console.WriteLine(a));

        //to dictionary with unique index each:
        //Method-1:
        Dictionary<int, int> dResult = new Dictionary<int, int>();
        for (int i = 0; i < list_duplicate_elem.Count; i++)
        {
            dResult.Add(i, list_duplicate_elem[i]);
        }

        //Method-2:
        Dictionary<int, int> dResult_02 = list_duplicate_elem
            .Select((value, index) => new { value, index })
            .ToDictionary(x => x.index + 1, x => x.value);

        //To Dictionary
        array_03.ToDictionary(key => key, value => value);
        array_03.ToDictionary(a => a, a => a);

        //ToDictionary: [List with Duplicate elements]
        list_duplicate_elem.GroupBy(a => a).ToDictionary(a => a.Key, a => a.ToList());

        //Map:
        Dictionary<string, List<int>> dict_02 = new Dictionary<string, List<int>>();
        dict_02.Add("name", list_02);

        //Loop Over Dictionary:

        //Type-1
        foreach (var item in dResult_02)
        {
            var key = item.Key;
            var value = item.Value;
        }

        //Type-2
        foreach (KeyValuePair<int, int> item in dResult_02)
        {
            var key = item.Key;
            var value = item.Value;
        }

        //copying elements from one dictionary to another key by key:
        Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
        foreach (var key in dict_02.Keys)
        {
            map.Add(key, dict_02[key].Select(s => s).ToList());
        }

        //Stack
        Stack<int> stack = new Stack<int>();
        stack.Push(100);
        stack.Push(200);
        stack.Pop();

        //returns top element
        var top = stack.Peek();

        foreach (int i in stack)
        {
            var stackItem = i;
        }

        //array to stack
        string[] array_values = { "Dot", "Net", "Perls" };

        // Array to Stack
        var stack_from_array = new Stack<string>(array_values);

        //List to Stack
        var stack_from_List = new Stack<int>(list_duplicate_elem);

        //stack to list and array:
        stack.ToList();
        stack.ToArray();

        //all operations of array and list are in stack also
        //Stack - //where //select //distinct //except //firstOrDefault //First()
        stack.GroupBy(a => a).ToDictionary(key => key, value => value);

        //Queue
        Queue<int> q = new Queue<int>();
        q.Enqueue(5);   // Add 5 to the end of the Queue.
        q.Enqueue(10);  // Then add 10. 5 is at the start.
        q.Enqueue(15);  // Then add 15.
        q.Enqueue(20);  // Then add 20.

        q.Dequeue();

        //q to array
        q.ToArray();

        // Array to Stack
        var queue_from_array = new Queue<string>(array_values);

        //arrayList
        ArrayList arrayList = new ArrayList();
        string[] array_of_string = new string[] { "a", "b" };
        arrayList.Add(array_of_string);
        int[] array_of_int = new int[] { 1, 2, 3 };
        arrayList.Add(array_of_int);

        //Hash Set

        //A HashSet is an unordered collection of the unique elements
        //prevent duplicates from being inserted in the collection
        //performance is concerned, it is better in comparison to the list.
        //https://www.c-sharpcorner.com/article/working-with-hashset-in-c-sharp/

        HashSet<int> hashSet = new HashSet<int>();
        HashSet<string> hashSet_names = new HashSet<string> { "Rajeev", "Akash", "Amit" };
        HashSet<string> hashSet_names_02 = new HashSet<string> { "Rajeev_2", "Akash_2", "Amit_2" };

        //duplicates are not added into collection.
        hashSet_names.Add("Rajeev");
        foreach (var name in hashSet_names)
        {
            Console.WriteLine(name);
        }

        //all the same operations as array and list

        //unique operations mainiting distinct property of sets:
        hashSet_names.UnionWith(hashSet_names_02);
        hashSet_names.IntersectWith(hashSet_names_02);

        //all the names in list1 not in list2
        hashSet_names.ExceptWith(hashSet_names_02);

        //Get unique array set from hash set or apply Distinct:

        //List to hashset
        HashSet<int> hashSet_from_list = new HashSet<int>(list_duplicate_elem);

        //Array to HashSet
        HashSet<int> hashSet_from_array = new HashSet<int>(list_duplicate_elem.ToArray());
        foreach (var set in hashSet_from_array)
        {
            Console.WriteLine(set);
        }

        //Sorted Set
        //https://www.dotnetperls.com/sortedset
        SortedSet<string> sortedSet = new SortedSet<string>();

        // Add 4 elements.
        sortedSet.Add("perls");
        sortedSet.Add("net");
        sortedSet.Add("dot");
        sortedSet.Add("sam");

        // Remove an element.
        sortedSet.Remove("sam");

        // Print elements in set.
        foreach (string val in sortedSet) // ... Alphabetical order.
        {
            Console.WriteLine(val);
        }

        //unique functionalities:

        sortedSet.RemoveWhere(element => element.StartsWith("s"));
        //sortedSet.Clear();

        List<string> list_with_set = new List<string>();
        list_with_set.Add("a");
        list_with_set.Add("y");
        sortedSet.ExceptWith(list_with_set);

        //overlaps: common elements with list
        bool isOverlap = sortedSet.Overlaps(list_with_set);

        // Union the two collections.
        sortedSet.UnionWith(list_with_set);
        //IntersectWith
        //isSubsetOf
        //SetEquals
        //Reverse

        //Substring
        string input = "OneTwoThree";
        // Get first three characters.
        string sub = input.Substring(0, 3);

        //String ahs this ubstring or not?
        input.Contains(sub);

        //Iterating over characters in string:
        int counter = 0;
        for (int e = 0; e < s1.Length; e++)
        {
            if (s1[e] == '.')
            {
                counter++;
            }
        }

        //Index Of:
        const string value_Index_Check = "Your dog is cute.";
        // Test with IndexOf method.
        if (value_Index_Check.IndexOf("dog") != -1)
        {
            Console.WriteLine("string contains dog!");
        }

        // Get index of character then find substring using that character:
        const string dummy_01 = "I have a cat";
        // Location of the letter c.
        int index_of_c = dummy_01.IndexOf('c');
        // Remainder of string starting at c.
        string d = dummy_01.Substring(index_of_c);
        Console.WriteLine(d);

        //Loop through all instances of letter a
        // The input string.
        string dummy_string = "I have a cat";
        // Loop through all instances of the letter a.
        int k_ = 0;
        while ((k_ = dummy_string.IndexOf('a', k_)) != -1)
        {
            // Print out the substring.
            Console.WriteLine(dummy_string.Substring(k_));

            // Increment the index.
            k_++;
        }
        /*ave a cat
            a cat
            at*/

        string comma_string = ":100,200";
        // Skip the first character with a startIndex of 1.
        int comma = comma_string.IndexOf(',', 1);
        Console.WriteLine(comma);

        //concatenate
        string s1_cat = "string1";
        string s2_cat = "string2";
        string s3_cat = string.Concat(s1_cat, s2_cat);
        Console.WriteLine(s2);

        //LAST Index of and Ignore Case both used:
        // Find the last occurrence of this string, ignoring the case.
        string value_lastIndex = "Dot Net Perls";
        int index4 = value_lastIndex.LastIndexOf("PERL", StringComparison.InvariantCultureIgnoreCase);
        if (index4 != -1)
        {
            Console.WriteLine(index4);
            Console.WriteLine(value_lastIndex.Substring(index4));
        }

        //String Opertaions:
        //https://www.dotnetperls.com/string

        //Compare
        //This method determines the sort order of strings.
        //If the first string is bigger, the result is 1. If the first string is smaller, the result is -1.
        //If both strings are equal, the result is 0
        string.Compare(s1, s2);
        s1.CompareTo(s2);

        //equality
        bool isStringEqual = s1.Equals(s2);
        bool isEqual_comp = s1 == s2 ? true : false;

        //Null empty etc.
        String.IsNullOrWhiteSpace("cc");
        String.IsNullOrEmpty("aaa");

        //CopyTo
        string value1 = "Dot Net Perls";
        char[] array1 = new char[3];
        // Copy the fifth, sixth, and seventh characters to the array.
        value1.CopyTo(4, array1, 0, 3);
        // Output the array we copied to.
        Console.WriteLine("--- Destination array ---");
        Console.WriteLine(array1.Length);
        Console.WriteLine(array1);

        //Starts With
        //Ends With
        if (input.StartsWith("http://www.site.com"))
        {
            Console.WriteLine(true);
        }

        //Insert  Type-1
        string names = "Romeo Juliet";
        string shakespeare = names.Insert(6, "and ");
        Console.WriteLine(shakespeare);

        //Insert substring in string
        string names2 = "The Taming of Shrew";
        int index2 = names2.IndexOf("of ");
        string shakespeare2 = names2.Insert(index2 + "of ".Length, "the ");
        Console.WriteLine(shakespeare2);
        //The Taming of >>the<< Shrew, the being inserted here

        //Remove
        string test1_r = "0123456";
        // ... Start removing at index 3 till the end //012 is the output
        string result1 = test1_r.Remove(3);
        // ... Displays the first three characters.
        // 2. Remove range of characters in string.
        string test2 = "012 345 678";
        int index1 = test2.IndexOf(' ');
        int index2_r = test2.IndexOf(' ', index1 + 1);
        string result2 = test2.Remove(index1, index2_r - index1);
        Console.WriteLine(result2);// 012 678 is the output:

        //Replace:
        const string input_replace = "key tool";
        string output_replaced = input_replace.Replace("key ", "keyword ");

        //minify-replace
        string p = " \n   oop";
        p = p.Replace(Environment.NewLine, string.Empty);

        //HashCode as used in Hashtables:
        string value_code = "";
        for (int i = 0; i < 10; i++)
        {
            value_code += "x";
            // This calls the unsafe code listed on this page.
            Console.WriteLine("GETHASHCODE: " + value_code.GetHashCode());
        }

        //SPLIT:
        string data = "there is a cat";
        // Split string on spaces (this will separate all the words).
        string[] words = data.Split(' ');
        foreach (string word in words)
        {
            Console.WriteLine("WORD: " + word);
        }

        //Regex:
        string value_regex = "cat\r\ndog\r\nanimal\r\nperson";
        // Split the string on line breaks.
        // ... The return value from Split is a string array.
        string[] lines = Regex.Split(value_regex, "\r\n");

        //Regex-Split on all words
        const string sentence = "Hello, my friend";
        // Split on all non-word characters.
        // ... This returns an array of all the words.
        string[] words_reg = Regex.Split(sentence, @"\W+");
        foreach (string value in words_reg)
        {
            Console.WriteLine("WORD: " + value);
        }
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        //Split on directory spacer
        string dir = "c:/gg?bb";
        string[] parts = dir.Split('\\');

        //more than one delimiter
        string[] result_array = dir.Split(new char[] { ' ', ',' });

        //JOIN:
        //Convert Array to String Comma sepearted
        string[] arr_join = { "one", "two", "three" };
        Console.WriteLine(string.Join(",", arr_join));
        //one,two,three

        //Length:
        string abc_01 = "v";
        int len_string = abc_01.Length;
        if (arr_join[arr_join.Length - 1] == "abc") { }

        //pad right
        string s_pad = "cat".PadRight(10, '0'); //cat 0000000 with 10 spaces

        //to lower to upper:
        string lower = s_pad.ToLower();

        //Trim:
        string st = "  This is an example string. ";
        // Call Trim instance method.
        // This returns a new string copy.
        st = st.Trim();

        //Convert List to String Comma seperated
        var list_join = new List<string>() { "cat", "dog", "rat" };
        // Join the strings from the List.
        string joined = string.Join<string>("*", list_join);
        //cat*dog*rat

        int[,] matrix = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
        int[,] matrix_02 = new int[3, 4] {
               {0, 1, 2, 3} ,   /*  initializers for row indexed by 0 */
               {4, 5, 6, 7} ,   /*  initializers for row indexed by 1 */
               {8, 9, 10, 11}   /*  initializers for row indexed by 2 */
        };

        //getting value from matrix
        int matrix_val = matrix_02[2, 3];

        int ii, jj;
        //5x2 matrix:
        for (ii = 0; ii < 5; ii++)
        {
            for (jj = 0; jj < 2; jj++)
            {
                Console.WriteLine("a[{0},{1}] = {2}", ii, jj, matrix[ii, jj]);
            }
        }

        //substrings and print combinations
        string pattern_string = "abcdefghi";
        for (int i = 1; i < pattern_string.Length; i++)
        {
            // Be careful with the end index.
            for (int j = 0; j <= pattern_string.Length - i; j++)
            {
                string substring = pattern_string.Substring(i, j);
                //Console.WriteLine(substring);
                //all combinations of 1
                //all combinations of 2
            }
        }

        //Remove Elements while Traversing:
        List<int> lst = new List<int>();
        lst.Add(1);
        lst.Add(2);
        lst.Add(3);
        foreach (var item in lst)
        {
            if (item > 1)
            {
                //lst.Remove(item);    //Not possible - will generate error!
            }
        }

        //Method:1 Remove by creating a reference of list in memory:
        foreach (var item in lst.ToList())
        {
            if (item == 2)
            {
                lst.Remove(item);    //Works!!
            }
        }
        lst.ForEach(a => Console.WriteLine(a));

        //Method-2 list in reverse order:
        for (int i = lst.Count - 1; i > 0; i--)
        {
            if (lst[i] == 3)
            {
                lst.RemoveAt(i);

            }
        }
        lst.ForEach(a => Console.WriteLine(a));

        //Read Comma Speaerated Input File and Split on comma
        /*int io = 0;
        foreach (string line in File.ReadAllLines("TextFile1.txt"))
        {
            string[] parts_string_array = line.Split(',');
            foreach (string part in parts_string_array)
            {
                Console.WriteLine("{0}:{1}", io, part);
            }
            io++; // For demonstration.
        }*/

        return null;
    }

    public static void print_Tree(BinaryTree tree)
    {
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);

        Console.WriteLine("Preorder traversal " +
                           "of binary tree is ");
        tree.printPreorder();

        Console.WriteLine("\nInorder traversal " +
                            "of binary tree is ");
        tree.printInorder();

        Console.WriteLine("\nPostorder traversal " +
                              "of binary tree is ");
        tree.printPostorder();

        Console.WriteLine("\n");
    }

    //demo class person
    public class Person
    {
        int id;
        string name;

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }

    /* Class containing left and  
    right child of current 
    node and key value*/
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        // Root of Binary Tree 
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        /* Given a binary tree, print  
           its nodes according to the 
           "bottom-up" postorder traversal. */
        public static void printPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree 
            printPostorder(node.left);

            // then recur on right subtree 
            printPostorder(node.right);

            // now deal with the node 
            Console.Write(node.key + " ");
        }

        /* Given a binary tree, print  
           its nodes in inorder*/
        public static void printInorder(Node node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.left);

            /* then print the data of node */
            Console.Write(node.key + " ");

            /* now recur on right child */
            printInorder(node.right);
        }

        /* Given a binary tree, print 
           its nodes in preorder*/
        public static void printPreorder(Node node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.key + " ");

            /* then recur on left sutree */
            printPreorder(node.left);

            /* now recur on right subtree */
            printPreorder(node.right);
        }

        // Wrappers over above recursive functions 
        public void printPostorder() { printPostorder(root); }
        public void printInorder() { printInorder(root); }
        public void printPreorder() { printPreorder(root); }
    }

} //end of main class

