
using CToJs.Models;
using Newtonsoft.Json;
using CToJs.Content;

User user1 = new User(1,"Cemile","Ismayilzade",new Adresses("Qax","Azerbaijan"),new Languages("az","eng"));
User user2 = new User(2,"Lala","Ismayilova",new Adresses("Qax","Azerbaijan"),new Languages("az","rus"));
BaseEntity.users.Add(user1);
BaseEntity.users.Add(user2);

string json=JsonConvert.SerializeObject(BaseEntity.users);
Console.WriteLine(json);

//using (StreamWriter sw = new StreamWriter(@"C:\Users\Aysel\OneDrive\İş masası\MyTasks\StreamSer\MyFolderEx\Test2.txt"))
//{
//    sw.WriteLine(json);
//}

//using(StreamReader sr=new StreamReader(@"C:\Users\Aysel\OneDrive\İş masası\MyTasks\StreamSer\MyFolderEx\Test2.txt"))
//{
//    Console.WriteLine(sr.ReadToEnd()); ;
//}