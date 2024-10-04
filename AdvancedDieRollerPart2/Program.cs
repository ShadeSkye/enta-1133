namespace AdvancedDieRollerPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program ProgramInstance = new Program();
            ProgramInstance.StartGame();
            
        }

        /// <summary>
        /// Using this as a function provides replayability.
        /// </summary>
        internal void StartGame()
        {
            // Creating new instances of the GameManager class.
            GameManager GameManagerInstance = new GameManager();

            GameManagerInstance.GreetPlayer();
        }

        // This function is used to make text be slowly printed out on screen rather than instantly.
        public void Print(string text, int speed = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
        }
    }
}
