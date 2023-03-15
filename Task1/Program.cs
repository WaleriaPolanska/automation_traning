namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i * i;
            }
            
            float[] array2 = new float[10];
           
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = i * i * i;
            }
                
            double[] array3 = new double[10];
           
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
            }
        }
    }
}