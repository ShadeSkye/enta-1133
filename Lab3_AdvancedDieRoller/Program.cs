namespace Lab3_AdvancedDieRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IntroSequence x = new IntroSequence();
            x.Intro();

            Player z = new Player();
            z.PickPlayerDie();

        }
    }
}
