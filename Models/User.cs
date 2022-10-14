namespace Net_Evaluation.Models
{
public class User
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public string Email {get;set;} = string.Empty;
        public double Phone {get;set;} 
        public List<Type>? Types { get; set; }

    }
}