 class Program
    {
        static void Main(string[] args)
        {
    Console.WriteLine("Questão 3");
            Queue<int> fila = new Queue<int>();
            fila.Enqueue(3);
            fila.Enqueue(5);
            fila.Enqueue(21);
            fila.Enqueue(33);
            fila.Enqueue(59);

            fila.Dequeue();
            fila.Dequeue();

            foreach (int elementos3 in fila)
            {
                Console.WriteLine(elementos3);
            }
}
}