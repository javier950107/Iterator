using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            SocialSpammer spammer = new SocialSpammer();
            Facebook facebook = new Facebook();
            ProfileIterator iterator = facebook.createFriendsIterator("normal");
            spammer.send(iterator, "Importan message");

            //ProfileIterator iterator1 = facebook.createCoworkersIterator("normal");
            //spammer.send(iterator1, "Importan message a los coworkers");
        }
    }
}
