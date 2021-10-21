namespace Test
{
    public class Human
    {
        public int Age { get; set; }
        public string SkinColour { get; set; }

        public Human(int age, string skinColour)
        {
            Age = age;
            SkinColour = skinColour;
        }
        
        public string ToString()
        {
            return $"Age is {Age} \nSkincolour is {SkinColour}";
        }
    }
}