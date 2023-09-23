class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1");
            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(4);
            lista.Add(6);
            lista.Add(9);
            lista.Add(12);

            lista.Remove(4);
            lista.Remove(9);

            bool resultado = lista.Contains(2);

            foreach (int elementos1 in lista)
            {
                Console.WriteLine(elementos1);
                Console.WriteLine(resultado);
            }
}
}