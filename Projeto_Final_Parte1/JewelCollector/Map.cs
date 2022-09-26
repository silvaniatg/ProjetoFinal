public class Map {

    private ItemMap[,] Matriz = new ItemMap[10, 10];

    public Map ()
    {
        for (int i = 0; i < Matriz.GetLength(0); i++) {
            for (int j = 0; j < Matriz.GetLength(1); j++) {
                Matriz[i, j] = new Empty();
            }            
        }
    }
    
    public void Insert(ItemMap item, int x, int y)
    {

        Matriz[x, y] = item;
    }

    public void Update(Robot robot, int x_old, int y_old, int x, int y)
    {

        Matriz[x_old, y_old] = new Empty();
        Matriz[x, y] = robot;
    }

   public List<Jewel> GetJewels(int x, int y){

        List<Jewel> NearJewels = new List<Jewel>();     

        if (Matriz[x, y+1] is Jewel Jewel1){
            NearJewels.Add(Jewel1);
            Matriz[x, y+1] = new Empty();
        }
        if (Matriz[x, y-1] is Jewel Jewel2){
            NearJewels.Add(Jewel2);
            Matriz[x, y-1] = new Empty();            
        }
        if (Matriz[x+1, y] is Jewel Jewel3){
            NearJewels.Add(Jewel3);
            Matriz[x+1, y] = new Empty();            
        }
        if (Matriz[x-1, y] is Jewel Jewel4){
            NearJewels.Add(Jewel4);
            Matriz[x-1, y] = new Empty();            
        }
        return NearJewels;

    }

    public bool IsAllowed(int x, int y){

        return Matriz[x, y] is Empty;
    }
    public void Print() {
      
        for (int i = 0; i < Matriz.GetLength(0); i++) {
            for (int j = 0; j < Matriz.GetLength(1); j++) {
            Console.Write(Matriz[i, j]);
            }
            Console.Write("\n");
        }
    }
}