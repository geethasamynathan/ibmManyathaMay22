// See https://aka.ms/new-console-template for more information

using System.IO;
/*
//Example :1
string path = @"D:\query.txt";
string [] contentfromfile;
if(File.Exists(path))
{
    contentfromfile = File.ReadAllLines(path);
    foreach (var item in contentfromfile)
    {
        Console.WriteLine(item);
    }
}

*/

//Example :2
/*
string path = @"D:\query.txt";
string contentfromfile;
if (File.Exists(path))
{
    contentfromfile = File.ReadAllText(path);
    Console.WriteLine(contentfromfile);
    
}
*/

/*
//Example :3  copying file from one file to another
string path = @"D:\query.txt";
string copyPath = @"D:\newquery.txt";
File.Copy(path, copyPath);

*/

//Example :4  Delete a file 

string deletePath = @"D:\newquery.txt";
File.Delete(deletePath);
