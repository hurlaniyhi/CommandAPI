namespace CommandAPI.Dtos
{
    public class CommandReadDto
    {
        public int Id {get; set;}
        public string HowTo {get; set;}
        public string Platform {get; set;}  // our response will not include Platform property if we comment this out
        public string CommandLine {get; set;}
    }
}