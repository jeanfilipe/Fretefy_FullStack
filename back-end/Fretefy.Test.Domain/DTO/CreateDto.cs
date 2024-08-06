using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Fretefy.Test.Domain.DTO
{
    public class CreateDto
    {
       public  string RegionName { get; set; } 
       public  string State { get; set; }
        
       public  string[] cities { get; set; }
    }


}
