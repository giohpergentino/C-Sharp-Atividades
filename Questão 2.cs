 class Program
    {
        static void Main(string[] args)
        {
    Console.WriteLine("Questão 2");
            Stack<int> pilha = new Stack<int>();
            pilha.Push(5);
            pilha.Push(15);
            pilha.Push(25);
            pilha.Push(35);
            pilha.Push(45);

            pilha.Pop();
            pilha.Pop();
            pilha.Pop();

            foreach (int elementos2 in pilha)
            {
                Console.WriteLine(elementos2);
            }
}
}
