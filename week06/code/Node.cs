public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {            // Do not insert duplicates
            return;
        }
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
         if (value < Data)
        {
            // Si no hay hijo izquierdo, el valor no existe
            if (Left is null)
                return false;

            // Llamada recursiva
            return Left.Contains(value);
        }
        else // value > Data
        {
            // Caso 3: buscar en el subárbol derecho
            if (Right is null)
                return false;

            // Llamada recursiva
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Altura del subárbol izquierdo
        int leftHeight = 0;
        if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }

        // Altura del subárbol derecho
        int rightHeight = 0;
        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }

        // Altura del nodo actual
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}