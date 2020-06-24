using algorithmStudy.Services.Graph;
using System;
using System.Collections.Generic;

namespace algorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SinglyLink Test
            //Console.WriteLine("--SinglyLink Start---------------------");
            //SinglyLink<string> singly = new SinglyLink<string>();
            //singly.Head = new Node<string>("B");
            //singly.append("D");
            //singly.prepend("A");
            //singly.insert(2, "C");
            //singly.insert(4, "E");
            //singly.display();
            //Console.WriteLine("长度：" + singly.length);
            //Console.WriteLine("索引为3的是：" + singly.get(3));
            //Console.WriteLine("E的索引是：" + singly.indexOf("E"));
            //singly.remove(0);
            //Console.WriteLine("移除索引0后：");
            //singly.display();
            //Console.WriteLine("--SinglyLink End---------------------");
            #endregion

            #region LoopLink Test
            //Console.WriteLine("--LoopLink Start---------------------");
            //LoopLink<string> loop = new LoopLink<string>(new Node<string>("B"));
            //loop.prepend("A");
            //Console.WriteLine("尾部：" + loop.Tail.Data);
            //loop.append("D");
            //Console.WriteLine("尾部：" + loop.Tail.Data);
            //loop.insert(2, "C");
            //loop.insert(4, "E");
            //Console.WriteLine("长度：" + loop.length);
            //Console.WriteLine("索引为3的是：" + loop.get(3));
            //Console.WriteLine("E的索引是：" + loop.indexOf("E"));
            //Console.WriteLine("尾部：" + loop.Tail.Data);
            //loop.display();
            //loop.remove(1);
            //Console.WriteLine("移除索引1后：");
            //Console.WriteLine("尾部：" + loop.Tail.Data);
            //loop.display();
            //Console.WriteLine("--LoopLink End---------------------");
            #endregion

            #region DoubleLink Test
            //Console.WriteLine("--DoubleLink Start---------------------");
            //DoubleLink<string> doublel = new DoubleLink<string>(new Node<string>("B"));
            //doublel.append("C");
            //doublel.append("D");
            //doublel.prepend("A");
            //doublel.insert(4,"E");
            //Console.WriteLine("尾部：" + doublel.Tail.Data);
            //Console.WriteLine("长度：" + doublel.length);
            //Console.WriteLine("索引尾0的是：" + doublel.get(0));
            //doublel.display();
            //Console.WriteLine("D的索引是：" + doublel.indexOf("D"));
            //doublel.remove(0);
            //Console.WriteLine("移除索引0后：");
            //Console.WriteLine("尾部：" + doublel.Tail.Data);
            //doublel.display();
            //Console.WriteLine("--DoubleLink End---------------------");
            #endregion

            #region SeqStack Test
            //Console.WriteLine("--SeqStack Start---------------------");
            //SeqStack<string> seqStack = new SeqStack<string>(10);
            //seqStack.push("A");
            //seqStack.push("B");
            //seqStack.push("C");
            //Console.WriteLine("移除了" + seqStack.pop());
            //Console.WriteLine("栈顶是" + seqStack.getTop());
            //seqStack.display();
            //Console.WriteLine("--SeqStack Start---------------------");
            #endregion

            #region SeqQueue Test
            //Console.WriteLine("--SeqQueue Start---------------------");
            //SeqQueue<string> seqQueue = new SeqQueue<string>(10);
            //seqQueue.enter("A");
            //seqQueue.enter("B");
            //seqQueue.enter("C");
            //seqQueue.enter("D");
            //seqQueue.display();
            //Console.WriteLine(seqQueue.exit()+"出队");
            //Console.WriteLine(seqQueue.exit() + "出队");
            //Console.WriteLine("E入队");
            //seqQueue.enter("E");
            //Console.WriteLine("队首的是" + seqQueue.getFront());
            //Console.WriteLine("队尾的是" + seqQueue.getRear());
            //seqQueue.display();
            //Console.WriteLine("--SeqSeqQueueStack Start---------------------");
            #endregion

            #region MinHeap Test
            //Console.WriteLine("--MinHeap Start---------------------");
            //MinHeap<int> minHeap = new MinHeap<int>(10);
            //minHeap.Push(10);
            //minHeap.Push(2);
            //minHeap.Push(3);
            //minHeap.Push(1);
            //minHeap.Push(5);
            //minHeap.display();
            //minHeap.Pop();
            //minHeap.display();
            //Console.WriteLine("--MinHeap Start---------------------");
            #endregion

            #region MaxHeap Test
            //Console.WriteLine("--MaxHeap Start---------------------");
            //MaxHeap<int> maxHeap = new MaxHeap<int>(10);
            //maxHeap.Push(10);
            //maxHeap.Push(2);
            //maxHeap.Push(3);
            //maxHeap.Push(1);
            //maxHeap.Push(5);
            //maxHeap.display();
            //maxHeap.Pop();
            //maxHeap.display();
            //Console.WriteLine("--MaxHeap Start---------------------");
            #endregion

            #region BubbleSort Test
            //Console.WriteLine("--BubbleSort Start---------------------");
            //int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9};
            //BubbleSort<int> sort = new BubbleSort<int>(arr);
            //sort.display();
            //Console.WriteLine("--BubbleSort Start---------------------");
            #endregion

            #region SelectionSort Test
            //Console.WriteLine("--SelectionSort Start---------------------");
            //int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            //SelectionSort<int> sort = new SelectionSort<int>(arr);
            //sort.display();
            //Console.WriteLine("--SelectionSort Start---------------------");
            #endregion

            #region InsertionSort Test
            //Console.WriteLine("--InsertionSort Start---------------------");
            //int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            //InsertionSort<int> sort = new InsertionSort<int>(arr);
            //sort.display();
            //Console.WriteLine("--InsertionSort Start---------------------");
            #endregion

            #region HeapSort Test
            //Console.WriteLine("--HeapSort Start---------------------");
            //int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            //HeapSort<int> sort = new HeapSort<int>(arr);
            //sort.display();
            //Console.WriteLine("--HeapSort Start---------------------");
            #endregion

            #region MergeSort Test
            //Console.WriteLine("--MergeSort Start---------------------");
            ////int[] arr = { 2, 5, 6, 70, 30, 20, 3 };
            //int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            //MergeSort<int> sort = new MergeSort<int>(arr);
            //sort.display();
            //Console.WriteLine("--MergeSort Start---------------------");
            #endregion

            #region QuickSort Test
            //Console.WriteLine("--QuickSort Start---------------------");
            //int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            ////int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            //QuickSort<int> sort = new QuickSort<int>(arr);
            //sort.display();
            //Console.WriteLine("--QuickSort Start---------------------");
            #endregion

            #region LinearSearch Test
            //Console.WriteLine("--LinearSearch Start---------------------");
            //int[] arr = { 2, 5, 6, 70, 30, 20, 3, 1, 9 };
            //LinearSearch<int> search = new LinearSearch<int>(arr);
            //Console.WriteLine("1的index是：" + search.Search(1));
            //Console.WriteLine("0的index是：" + search.Search(0));
            //Console.WriteLine("80的index是：" + search.Search(80));
            //Console.WriteLine("--LinearSearch Start---------------------");
            #endregion

            #region BinarySearch Test
            //Console.WriteLine("--BinarySearch Start---------------------");
            //int[] arr1 = { 1, 2, 3, 5, 6, 9, 20, 30, 70 };
            //BinarySearch<int> bsearch = new BinarySearch<int>(arr1);
            //Console.WriteLine("1的index是：" + bsearch.Search(1));
            //Console.WriteLine("0的index是：" + bsearch.Search(0));
            //Console.WriteLine("80的index是：" + bsearch.Search(80));
            //Console.WriteLine("--BinarySearch Start---------------------");
            #endregion

            #region BinaryTree Test
            //Console.WriteLine("--BinaryTree Start---------------------");
            //BinaryTree<int> binaryTree = new BinaryTree<int>();
            //binaryTree.Add(100);
            //binaryTree.Add(80);
            //binaryTree.Add(108);
            //binaryTree.Add(70);
            //binaryTree.Add(60);
            //binaryTree.Add(30);
            //binaryTree.Add(20);
            //binaryTree.Add(8);
            //binaryTree.Add(6);
            //binaryTree.Add(3);
            //binaryTree.Add(101);
            //binaryTree.Add(102);
            //binaryTree.PreorderTraversal(binaryTree.Head);
            //Console.WriteLine("2的索引：" + binaryTree.indexOf(2));
            //binaryTree.Remove(3);
            //binaryTree.PreorderTraversal(binaryTree.Head);
            //Console.WriteLine("--BinaryTree Start---------------------");
            #endregion

            #region GraphSearchs Test
            Console.WriteLine("--GraphSearchs Start---------------------");
            GraphSearchs<string> graphSearchs = new GraphSearchs<string>();
            //graphSearchs.NodeList = graphSearchs.InitSeed();
            //graphSearchs.BFS("Alice");
            List<GraphNode<string>> seed = new List<GraphNode<string>>
            {
                new GraphNode<string>() { Data = "A", Children = new[] { "B", "C", "D" } },
                new GraphNode<string>() { Data = "B", Children = new[] { "E", "F" } },
                new GraphNode<string>() { Data = "C", Children = new[] { "H" } },
                new GraphNode<string>() { Data = "D", Children = new[] { "I", "J" } },
                new GraphNode<string>() { Data = "E", Children = new[] { "K" } },
                new GraphNode<string>() { Data = "H", Children = new[] { "G" } },
                new GraphNode<string>() { Data = "J", Children = new[] { "L" } }
            };
            graphSearchs.NodeList = seed;
       
            graphSearchs.BFS("A", "G");
            Console.WriteLine("--GraphSearchs Start---------------------");
            #endregion
        }


    }
}
