string a = "2 + 25 + 3+4";

//tira espaços
List<string> b = new List<string>{a};
b = b[0].Split(" ").ToList();

List<string> final = new List<string>{" "};

foreach(var valor in final){
    Console.WriteLine(valor);
}

foreach(var valor in b){
    Console.WriteLine(valor);
}

Console.WriteLine("_______________________________");

for (int i = 0; i < b.Count(); i++)
{
    if(b[i].Contains("+")){
        var value = b[i].Split("+");
        
        for (int x = 0; x < value.Count(); x++)
        {
            Console.WriteLine(value[x]);
            Console.WriteLine("debug");
            if(b[i].Count() > 1)
                final.Add(value[x]);
            if(x != value.Count() - 1)
                final.Add("+");
        }    
    }
    else if(b[i].Contains("-")){
        var value = b[i].Split("-");

        if(final.Count() > 0)
        {
            final.Clear();
            for (int x = 0; x < i; x++)
            {
                final.Add(b[x]);    
            }
            
            for (int x = 0; x < value.Count(); x++)
            {
                // Console.WriteLine(value[x]);
                // Console.WriteLine("debug");
                final.Add(value[x]);
                if(x != value.Count() - 1)
                    final.Add("-");
            }    
        }
    }
    else if(b[i].Contains("*")){
        var value = b[i].Split("*");

        if(final.Count() > 0)
        {
            final.Clear();
            for (int x = 0; x < i; x++)
            {
                final.Add(b[x]);    
            }
            
            for (int x = 0; x < value.Count(); x++)
            {
                // Console.WriteLine(value[x]);
                // Console.WriteLine("debug");
                final.Add(value[x]);
                if(x != value.Count() - 1)
                    final.Add("*");
            }    
        }
    }
    else if(b[i].Contains("*")){
        var value = b[i].Split("*");

        if(final.Count() > 0)
        {
            final.Clear();
            for (int x = 0; x < i; x++)
            {
                final.Add(b[x]);    
            }
            
            for (int x = 0; x < value.Count(); x++)
            {
                // Console.WriteLine(value[x]);
                // Console.WriteLine("debug");
                final.Add(value[x]);
                if(x != value.Count() - 1)
                    final.Add("*");
            }    
        }
    }
    else if(b[i].Contains("%")){
        var value = b[i].Split("%");

        if(final.Count() > 0)
        {
            final.Clear();
            for (int x = 0; x < i; x++)
            {
                final.Add(b[x]);    
            }
            
            for (int x = 0; x < value.Count(); x++)
            {
                // Console.WriteLine(value[x]);
                // Console.WriteLine("debug");
                final.Add(value[x]);
                if(x != value.Count() - 1)
                    final.Add("%");
            }    
        }
    } else if(b[i])
}

Console.WriteLine(final.Count());
foreach(var valor in final){
    Console.WriteLine(valor);
}

// int[] c = new int[b.Count()];

// int count = 1;
// int count1 = 0;

// foreach(var value in b){
//     if(value == "+" || value == "-" || value == "*" || value == "/" || value == "%"){
//         c[count1] = count;
//         count1++;
//     }
//     count++;
// }

// foreach(var value in c){
//     if(value > 0){
//         Console.WriteLine(value-1);
//     }
// }