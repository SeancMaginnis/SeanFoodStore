using System;
using SeanFoodStore.Project;

namespace SeanFoodStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"
  _____   ___   ____  ____   __   _____     _____   ___    ___   ___         _____ ______   ___   ____     ___  __ 
 / ___/  /  _] /    ||    \ |  | / ___/    |     | /   \  /   \ |   \       / ___/|      | /   \ |    \   /  _]|  |
(   \_  /  [_ |  o  ||  _  ||_ |(   \_     |   __||     ||     ||    \     (   \_ |      ||     ||  D  ) /  [_ |  |
 \__  ||    _]|     ||  |  |  \| \__  |    |  |_  |  O  ||  O  ||  D  |     \__  ||_|  |_||  O  ||    / |    _]|__|
 /  \ ||   [_ |  _  ||  |  |     /  \ |    |   _] |     ||     ||     |     /  \ |  |  |  |     ||    \ |   [_  __ 
 \    ||     ||  |  ||  |  |     \    |    |  |   |     ||     ||     |     \    |  |  |  |     ||  .  \|     ||  |
  \___||_____||__|__||__|__|      \___|    |__|    \___/  \___/ |_____|      \___|  |__|   \___/ |__|\_||_____||__|                                                                                                                   
  _____________________________________________________________________________________________________________                                                                                                            
");
Console.WriteLine(Environment.NewLine);        
Console.WriteLine("Welcome to Sean's Food Store! \nPress any key to view our Menu");
Console.ReadKey();
App app = new App();
app.Run();
        }
    }
}
