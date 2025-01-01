namespace ConsoleApp72
{
    public class Graphik : Point
    {
        private int Z{get; set; }
        
        public int getZ()
        { 
            return Z;

        }

        public Graphik(int x, int y,int z) : base(x, y)
        {
            this.Z = z;
        }
    }
}