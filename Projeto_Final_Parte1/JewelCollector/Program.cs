public class JewelCollector {
    public static void Main() {

        Map map = new Map();        
        Robot robot = new Robot(map);

        

        map.Insert(new JewelRed(), 1, 9);
        map.Insert(new JewelRed(), 8, 8);
        map.Insert(new JewelGreen(), 9, 1);
        map.Insert(new JewelGreen(), 7, 6);
        map.Insert(new JewelBlue(), 3, 4);
        map.Insert(new JewelBlue(), 2, 1); 

        map.Insert(new Water(), 5, 0);
        map.Insert(new Water(), 5, 1);
        map.Insert(new Water(), 5, 2);
        map.Insert(new Water(), 5, 3);
        map.Insert(new Water(), 5, 4);
        map.Insert(new Water(), 5, 5);
        map.Insert(new Water(), 5, 6);
        map.Insert(new Tree(), 5, 9);
        map.Insert(new Tree(), 3, 9);
        map.Insert(new Tree(), 8, 3);
        map.Insert(new Tree(), 2, 5);
        map.Insert(new Tree(), 1, 4);

        Run(robot);        
  }

  public static void Run(Robot robot)
  {
      bool running = true;
        
      do {
            robot.map.Print();
            (int ItensBag, int TotalPoints) = robot.GetBagInfo();
            Console.WriteLine($"Itens Bag: {ItensBag} - Total Points: {TotalPoints}");

            Console.WriteLine("Enter the command: ");
            string command = Console.ReadLine();
  
            if (command.Equals("quit")) {
              running = false;
            } else if (command.Equals("w")) {
                robot.MoveNorth();
              
            } else if (command.Equals("a")) {
                robot.MoveWest();
              
            } else if (command.Equals("s")) {
                robot.MoveSouth();
            
            } else if (command.Equals("d")) {
                robot.MoveEast();
          
            } else if (command.Equals("g")) {
                robot.Get();
              
            }
      } while (running);
  }
}


