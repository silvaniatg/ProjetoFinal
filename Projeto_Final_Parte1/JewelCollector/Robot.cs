public class Robot : ItemMap {

    public Map map {get; private set;}    
    public int x, y;
    private List<Jewel> Bag = new List<Jewel>();

    public Robot(Map map, int x=0, int y=0){
        this.map = map;
        this.x = x;
        this.y = y;
        this.map.Insert(this, x, y);
    }

     public override string ToString()
    {
        return("ME ");
    }

    public void MoveNorth()
    {
        map.Update(this, this.x, this.y, this.x-1, this.y);
        this.x--;
        
    }

    public void MoveSouth()
    {
        if (map.IsAllowed(this.x+1, this.y)){

            map.Update(this, this.x, this.y, this.x+1, this.y);
            this.x++;

        }    
        

    }

     public void MoveEast()
     {
        if (map.IsAllowed(this.x, this.y+1)){

            map.Update(this, this.x, this.y, this.x, this.y+1);
            this.y++;

        }

        

     }

     public void MoveWest()
     {
        if(map.IsAllowed(this.x, this.y-1)){

            map.Update(this, this.x, this.y, this.x, this.y-1);
            this.y--;

        }     

     }

     public void Get()
     {
        List<Jewel> NearJewels = map.GetJewels(this.x, this.y);

        foreach (Jewel j in NearJewels)
            Bag.Add(j);       

     }   

    public (int, int) GetBagInfo()
    {
        int Points = 0;

        foreach (Jewel j in this.Bag)
            Points += j.Points;

        return (this.Bag.Count, Points);

    }
    
}