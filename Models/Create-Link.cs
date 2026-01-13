namespace all_access.Models
{
    public class Create_Link
    {
        //string url = null!;
       public string SourceUrl { 
        
            get { return SourceUrl; }
            set { 
                if (value.Length < 6 && string.IsNullOrEmpty(value))
             
                { 
                    
                    throw new ArgumentException("Invalid URL"); 
                }
            }
        }
    }
}
